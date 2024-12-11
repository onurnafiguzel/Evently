using Evently.Common.Application.Messaging;

namespace Evently.Modules.Events.Application.TicketTypes.UpdateTicketTypes;
public sealed record UpdateTicketTypePriceCommand(Guid TicketTypeId, decimal Price) : ICommand;

