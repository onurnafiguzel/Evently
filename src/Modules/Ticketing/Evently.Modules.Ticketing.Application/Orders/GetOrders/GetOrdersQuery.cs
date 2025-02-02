using Evently.Modules.Events.Application.Abstractions.Messaging;
using Evently.Modules.Ticketing.Application.Orders.GetOrder;

namespace Evently.Modules.Ticketing.Application.Orders.GetOrders;
public sealed record GetOrdersQuery(Guid CustomerId) : IQuery<IReadOnlyCollection<OrderResponse>>;

