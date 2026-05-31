namespace OrderEdit

open OrderTaking.Domain

module OrderEdit = 
    type findOrderLineDef = OrderLineId -> OrderLine list -> OrderLine
    let findOrderLine: findOrderLineDef = Undefined
    let changeOrderLinePrice (order: Order) (orderLineId: OrderLineId) (newPrice: Price) : Order =
        let orderLine = order.OrderLines |> findOrderLine orderLineId
        let newOrderLine = {orderLine with Price = newPrice}
        let newOrderLines = order.OrderLines |> replaceOrder