﻿using Evently.Modules.Events.Application.Abstractions.Messaging;

namespace Evently.Modules.Ticketing.Application.Carts.GetCart;
public sealed record GetCartQuery(Guid CustomerId) : IQuery<Cart>;
