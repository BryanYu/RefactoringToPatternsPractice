## 以Builder封裝複合物(Encapsulate Composite With Builder)

建置一個複合物的過程具有反覆性、複雜性或易發生錯誤

讓Builder處理所有細節，藉以簡化建置(build)



## 動機：

* Refactor to Builder是為了簡化用以創造複雜物件的程式碼
* 另一個動機是為了解除客戶碼和Composite程式碼的耦合關係


## 優點：

* 簡化客戶用以建構Composite(複合物)的程式碼
* 減少Composite創建過程中重複而易出錯的先天特性
* 讓客戶碼和Composite之間維持鬆偶合關係
* 允許被封裝的Composite或複雜物件有不同的表述(representations)


## 缺點：
* 無法提供意向清晰的介面



