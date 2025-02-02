﻿using Evently.Modules.Events.Application.Abstractions.Messaging;

namespace Evently.Modules.Ticketing.Application.Tickets.GetTicket;
public sealed record GetTicketQuery(Guid TicketId) : IQuery<TicketResponse>;

