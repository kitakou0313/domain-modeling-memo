// 関数の定義

let add1 x= x + 1
let add2 x y = x + y

// returnは明示的に書かなくていい
let squarePlusOne x = 
    let square = x * x
    square + 1

let areEqual x y =
    x = y

type AppleVariety = int
type BananaVariety = int
type CherryVariety = int

// AND型の定義（直積型）
type FruitSalad = {
    Apple: AppleVariety
    Banana: BananaVariety
    Cherry: CherryVariety
}

// OR型の定義（直和型）
type FruitSnack1 = 
    | Apple of AppleVariety
    | Banana of BananaVariety
    | Cherry of CherryVariety
type FruitSnack2 = 
    | AppleVariety
    | BananaVariety
    | CherryVariety

// 単純型
type ProductCode = ProductCode of string

// 型の定義、値の定義
//// レコード型
// typeで型定義
type Person = {First: string; Last: string}
//letで値定義
// レコード型の値を定義
let aPerson = {First = "test1"; Last = "test2"}
// パターンマッチで値を分解
let {First=first;Last=last} = aPerson
let first2 = aPerson.First
let last2 = aPerson.Last

//// 判別共用体
// ケースラベルを介して定義
type OrderQuantity = 
    | UnitQuantity of int
    | KilogramQuantity of float
let anOrderQtyInUnits = UnitQuantity 10
let anOrderQtyInKg = KilogramQuantity 2.5
// 選択型の分解
let printQuantity aOrderQty = 
    match aOrderQty with
    | UnitQuantity uQty -> printfn "Units: %d" uQty
    | KilogramQuantity kgQty -> printfn "Kilograms: %f" kgQty


// 型の合成によるドメインモデルの構築
type CheckNumber = CheckNumber of string

type CardNumber = CardNumber of string
type CardType = Visa | Mastercard
type CreditCardInfo = {
    CardType: CardType
    CardNumber: CardNumber
}

type PaymentMethod = 
    | Cash
    | Check of CheckNumber
    | Card of CreditCardInfo

type PaymentAmount = PaymentAmount of decimal
type Currency = EUR | USD
type Payment = {
    Amount: PaymentAmount
    Currency: Currency
    Method: PaymentMethod
}

// type PayInvoice = UnpaidInvoice -> Payment -> PaidInvoice

// 省略可能な値
type PersonalInfo = {
    FirstName: string
    LastName: string
    Age: int option
}

// エラー
// type PayInvoiceError = UnpaidInvoice -> Payment -> Result<int, string>

// 値を返さない
type SaveCustomer = PersonalInfo -> unit

// コレクションを用いたモデリング
type Order = {
    OrderId: int
    Lines: string list
}
let aList = [1;2;3]
// cons演算子を使って配列
let aList2 = 0 :: aList
// let alist= aList :: 4 // これはエラー

// パターンを利用してリストを分解してその中の要素にアクセス
// リストリテラルを使ったパターンマッチ
let pringList1 aList = 
    match aList with
    | [] -> printfn "Empty list"
    | [x] -> printfn "Single element: %d" x
    | [x;y] -> printfn "Two elements: %d, %d" x y
    | longerList -> printfn "There are more than two elements: %A" longerList

// cons演算子を使ってのパターンマッチを利用
let pringList2 aList = 
    match aList with
    | [] -> printfn "Empty list"
    | first :: rest -> printfn "First element: %d, Rest of the list: %A" first rest

pringList1 []
pringList1 [1]
pringList1 [2;3]
pringList1 [4;5;6]