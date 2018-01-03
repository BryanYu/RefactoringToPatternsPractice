## 以Factory封裝眾多Classes(Encapsulate Classes With Factory)

客戶端直接具現`位於同一個Package`內並實作共同interface`的classes。

把class建構式改設為non-public並讓客戶端以Factory創建classes實體


## 動機：

* 提供一個嚴格執行`針對介面編程而非針對實作編程`
* 藏起無需在package外部曝光的classes
* 透過Factory提供意向清晰的Creation Method來創建實體，藉此簡化各個實體的建構工作




## 優點：

* 透過`目的清晰`的函式產生各種實體，藉此簡化創建過程
* 隱藏不需要公開的classes，並以此減輕package的概念重量
* 有助於強制執行`針對介面編程而非針對實作編程`

## 缺點：

* 如果必須創建新種類的實體，就得創造出新的Creation Methods或更新舊有的Creation Methods
* 當客戶端只能取用Factory的二進制碼，而不是源碼時，客製化能力會受到限制


