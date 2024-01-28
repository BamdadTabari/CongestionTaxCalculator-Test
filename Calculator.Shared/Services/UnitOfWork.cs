﻿using Calculator.Shared.EntityFramework.Configs;
using Calculator.Shared.Services.Interfaces;
using Calculator.Shared.Services.Repositories;

namespace Calculator.Shared.Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IDynamicTaxRulesService DynamicTaxRules { get; }
    public IStaticTaxCalculatorService StaticTaxCalculaotr { get; }


    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        DynamicTaxRules = new DynamicTaxRulesService(_context);
        StaticTaxCalculaotr = new StaticTaxCalculatorService();
    }

    public async Task<bool> CommitAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}