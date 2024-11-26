﻿using System;

namespace Auction.Wallet.Application.L2.Interfaces.Commands.Owners;

public record PutMoneyInWalletCommand(
    Guid OwnerId,
    decimal Money);