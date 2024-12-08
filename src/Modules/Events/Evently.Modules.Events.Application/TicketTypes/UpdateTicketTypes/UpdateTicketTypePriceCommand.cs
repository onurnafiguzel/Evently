﻿using Evently.Modules.Events.Application.Abstractions.Messaging;

namespace Evently.Modules.Events.Application.TicketTypes.UpdateTicketTypes;
public sealed record UpdateTicketTypePriceCommand(Guid TicketTypeId, decimal Price) : ICommand;

