# F# Hello World 入門

## 前提条件

- [.NET SDK](https://dotnet.microsoft.com/download) がインストールされていること

```bash
dotnet --version
# 例: 10.0.202
```

---

## 1. プロジェクトの初期化

`dotnet new` コマンドで F# のコンソールアプリケーションを作成する。

```bash
dotnet new console -lang "F#" -o HelloWorld
```

| オプション | 意味 |
|---|---|
| `console` | コンソールアプリテンプレート |
| `-lang "F#"` | 言語として F# を指定 |
| `-o HelloWorld` | 出力ディレクトリ名 |

実行後、以下の構成でディレクトリが生成される。

```
HelloWorld/
├── HelloWorld.fsproj   # プロジェクト定義ファイル
└── Program.fs          # エントリポイント
```

---

## 2. 生成されるファイルの確認

### `HelloWorld.fsproj`

.NET のプロジェクト設定ファイル。コンパイル対象のファイルやターゲットフレームワークを定義する。

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <Compile Include="Program.fs" />
  </ItemGroup>

</Project>
```

F# では `<Compile>` の順序がコンパイル順序に直結するため、ファイルが増えたときは依存関係の順に記述する必要がある。

### `Program.fs`

エントリポイントとなるソースファイル。

```fsharp
printfn "Hello, world"
```

`printfn` は書式付き文字列をstdoutへ出力し、末尾に改行を加える標準ライブラリ関数。`printf` の改行あり版。

---

## 3. ビルドと実行

### `dotnet run`（ビルド + 実行を一括で行う）

```bash
cd HelloWorld
dotnet run
```

```
Hello, world
```

### `dotnet build` + `dotnet run` を分けて実行する場合

```bash
dotnet build
dotnet run --no-build
```

---

## 4. コマンドリファレンス

| コマンド | 説明 |
|---|---|
| `dotnet new console -lang "F#" -o <名前>` | F# コンソールプロジェクトを作成 |
| `dotnet build` | プロジェクトをビルド |
| `dotnet run` | ビルドして実行 |
| `dotnet run --no-build` | ビルドをスキップして実行 |

---

## 5. F# の基本的な出力関数

| 関数 | 説明 |
|---|---|
| `printfn "..."` | stdout へ出力（末尾改行あり） |
| `printf "..."` | stdout へ出力（末尾改行なし） |
| `eprintfn "..."` | stderr へ出力（末尾改行あり） |

書式指定子を使った例:

```fsharp
let name = "world"
printfn "Hello, %s" name   // Hello, world
printfn $"Hello, {name}"   // Hello, world（補間文字列）
```
