﻿using Auction.Common.Infrastructure.Repositories.EntityFramework;
using Auction.Wallet.Application.L2.Interfaces.Repositories;
using Auction.Wallet.Infrastructure.EntityFramework;
using Auction.WalletMicroservice.Domain.Entities;
using System;

namespace Auction.Wallet.Infrastructure.Repositories.EntityFramework;

public class BillsRepository(ApplicationDbContext dbContext)
    : BaseEfRepositoryWithUpdate<ApplicationDbContext, Bill, Guid>(dbContext),
    IBillsRepository;