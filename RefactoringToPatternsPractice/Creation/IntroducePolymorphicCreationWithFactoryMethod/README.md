## 以Factory Method導入多型創建 (Introduce Polymorphic Creation With Factory Method)

繼承體系內的classes以類似方式實現某函式，其間的唯一差別只在物件創建手段

為該函式製作單個superclass版本，稱為Factory Method，專門負責處理物件的具現行為


## 動機：
Factory Method提供一種可使物件之創建動作多型化的辦法，他們總是被實作於class繼承體系內。

## 優點：
減少訂製型物件的創建手段所引發的重複
有效表達創建行為發生於何處以及可以怎樣覆寫他
強迫class必須實作Factory Method用到的型別

## 缺點：
可能會要求傳遞非必要參數給某些Factory Method實作者

