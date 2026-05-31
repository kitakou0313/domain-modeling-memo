namespace chap6

// 完全性の維持
// 例:1 ~ 1000の整数のみ持つ
type UnitQuantity = private UnitQuantity of int // private化して他から直接コンストラクタを呼べないように
module UnitQuantity = 
    let create qty = 
        if qty < 1 || qty > 1000 then
            Error "Unit Quantity must be between 1 and 1000"
        else
            Ok(UnitQuantity qty)
// moduleの中に型を定義しないのは、
// - module内でmoduleと同名の型を定義できない
// - {module名}.{コンストラクタ関数}だと意味的に不適切なため
// - {型名}.{適当な名前}だと型名の参照時に意味的に不適切なため
// memo:型でのビジネスルールの表現の意味論的なわかりやすさを重視しているためにこのような実装になっていそう
// Javaのように型のコンストラクタの挙動を変更できない