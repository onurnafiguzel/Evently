using Evently.Modules.Events.Application.Abstractions.Messaging;

namespace Evently.Modules.Ticketing.Application.Orders.GetOrder;
public sealed record GetOrderQuery(Guid OrderId) : IQuery<OrderResponse>;

