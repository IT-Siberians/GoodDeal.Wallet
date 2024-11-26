﻿using Auction.Common.Infrastructure.Repositories.InMemory;
using Auction.Wallet.Application.L2.Interfaces.Repositories;
using Auction.WalletMicroservice.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Auction.Wallet.Infrastructure.Repositories.InMemory;

public class BillsRepository(IList<Bill> entities)
    : BaseMemoryRepositoryWithUpdate<Bill, Guid>(entities),
    IBillsRepository;