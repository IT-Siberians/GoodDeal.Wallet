﻿using System;

namespace Auction.Wallet.Application.L2.Interfaces.Commands.Owners;

public record GetWalletBalanceQuery(Guid OwnerId);