## 以創建函式替代建構式(Replace Constructors With Creation Methods)

開發過程中為數眾多的classes建構式令客戶難以決定呼叫哪一個建構式

以目的清楚、返回物件實體的Creation Method取代建構式

## 動機：

* 過多的建構式會導致程式員誤用，降低開發速度
* 建構式無法充分傳達被建構出來的物件的先天性質
* 無法使用相同的建構式產出不同性質的物件


## 優點：
* 比建構式更能有效表達可獲得哪一種物件實體
* 突破建構式的限制，像是不能同時擁有兩個`引數個數與引數型別均相同`的建構式
* 更容易找出未使用的創建碼

## 缺點：
* 創建方式變得不標準：有些class用new創建，有些用Creation Method

