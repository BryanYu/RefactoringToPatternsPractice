## 將創建知識移至Factory(Move Creation Knowledge To Factory)

用以具現class的各種資料和程式碼蔓延於許多classes

把創建知識搬移至單個Factory class中

## 動機：

* 一旦`物件的創建知識`分散於多個class中，變會產生創建碼蔓延的壞味道




## 優點：

* 可以統合創建邏輯和具現(instantiation)/組態偏好(configuration)
* 將客戶端和創建邏輯解除耦合
*

## 缺點：
* 比直接具現(instantiation)設計更複雜 


