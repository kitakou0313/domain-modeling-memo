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