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