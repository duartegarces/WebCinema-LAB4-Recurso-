﻿namespace Utad_Proj_.Services
{
    using System.Threading.Tasks;
    using Utad_Proj_.Models;

    public interface IPurchaseService
    {
        Task CreatePurchaseAsync(CreatePurchaseArgs createPurchaseArgs);
    }
}