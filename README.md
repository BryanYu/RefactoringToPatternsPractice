# RefactoringToPatternsPractice
重構-向範式前進練習Lab

使用C#改寫書上的範例

# 系統設計上的常見問題

## 過度設計(Over-Engineering)
* 當程式碼的彈性或複雜度超過需求時，你便犯下了過度設計的毛病
* 會造成過度設計的原因是，我們預留了太多彈性以便應付將來的需求，但實際上有可能不會用到
* 過度設計會影響生產力，如果程式員繼承一個過渡的設計，原本他們可以很輕鬆的擴展或維護，現在卻必須花時間學習設計中細微的差別

## 範式萬靈丹(The Pattern Panacea)
* 不能對於範式(Pattern)有太多的依賴，要重新聚焦於小型、簡單、好理解的程式碼

## 設計不足
* 沒有時間進行重構
* 沒有良好的軟體設計知識
* 太過盼望快速加入新功能至既有系統
* 被迫同時進行太多專案

# 測試驅動開發(Test-Driven Development)

## 將編程轉成對話的方式

* 詢問(Ask)：透過撰寫測試程式來詢問系統問題
* 回答(Respond)：透過撰寫`可通過測試的程式碼`來回答問題
* 精煉(Refine)：透過強化觀念、去除非必要事物以釐清模糊地帶的方式來精煉、強化你的答覆
* 重複(Repeat)：透過詢問下一個問題來持續這樣的對話

## Kent Beck的測試驅動和持續重構，利用測試套件(xUnit)的方式

* 紅燈：建立一個測試，表達你期望程式做什麼事，由於你還未開始寫通過測試的程式碼，所以測試案例會是紅燈(失敗)。
* 綠燈：開始撰寫可以以最低限制通過測試的程式碼，在此階段沒有必要追求乾淨、無重複、簡單的設計。
* 重構：改善已經通過測試的設計。

## 測試驅動開發所帶來的好處

* 讓程式錯誤數量維持在低水平
* 重構時不感到害怕
* 製造出簡單、更好的程式碼
* 編程時沒有壓力

# 何謂範式(Pattern)

* 每個範式都是由三部分組成的規則，分別為描述情境、問題和解決方案
* 範式是曾經發生過的事，他是過程也是事物，同時也是現有事物的描述以及產生該事物的過程描述。

## 範式帶來的喜樂(Pattern Happy)

* pattern所帶來的樂趣是聰明的使用他們，讓我們集中注意力在去除重複、簡化的程式碼、以及讓程式碼明白傳達其目的。

## 條條大路通範式

* pattern都有一種結構圖，描述範式最常見的實作方式，但在實作過程中，盡量簡化你的pattern實作。

# 程式碼壞味道

## 常見的設計問題

* 重複的程式碼
* 不清晰的程式碼
* 複雜的程式碼


## 重構成為範式

### 創建(Creation)

* [以創建函式替代建構式(Replace Constructors With Creation Methods)](https://github.com/BryanYu/RefactoringToPatternsPractice/tree/master/RefactoringToPatternsPractice/Creation/ReplaceConstructorsWithCreationMethods)
* [將創建知識移至Factory(Move Creation Knowledge To Factory)](https://github.com/BryanYu/RefactoringToPatternsPractice/tree/master/RefactoringToPatternsPractice/Creation/MoveCreationKnowledgeToFactory))





