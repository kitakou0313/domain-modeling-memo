namespace OrderTaking.Domain

// 値オブジェクト
// 単一ケース共用体で定義する
type WidgeCode = WidgeCode of string
type GizmoCode = GizmoCode of string
type ProductCode = 
    | Wedget of WidgeCode
    | Gizmo of GizmoCode

type UnitQuantity = UnitQuantity of int
type KilogramQuantity = KilogramQuantity of decimal
type OrderQuantity = 
    | Unit of UnitQuantity
    | Kilos of KilogramQuantity

// エンティティ
type OrderId = Undefined
type OrderLineId = Undefined
type CustomerId = Undefined

type CustomerInfo = Undefined
type ShippingAddress = Undefined
type BillingAddress = Undefined
type Price = Undefined
type BillingAmount = Undefined

// 複数の情報を合わせて扱う場合はレコード型を利用
type OrderLine = {
    Id: OrderLineId
    OrderId: OrderId
    ProductCode: ProductCode
    OrderQuantity: OrderQuantity
}

type Order = {
    Id: OrderId
    CustomerId: CustomerId
    ShippingAddress: ShippingAddress
    BillingAddress: BillingAddress
    OrderLines: Order
    Price: Price
}