// 単純な値に対応する型の定義
// 型の名前 = ケース名 of ...で定義
type CustomerId = CustomerId of string

// ケース名がコンストラクタ関数になる
let customerId = CustomerId 44
