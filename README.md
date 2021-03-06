## ๐ ํ๋ก์ ํธ ๊ฐ์(Introduce Project)

### WPF MVVM

* WPF MVVM ํํ๋ฆฟ ํ๋ก์ ํธ๋ฅผ ์์ฑํฉ๋๋ค.

## ๐ก ์ฌ์ฉ๋ฒ(Tip)
 1. MVVM ๊ตฌ์ฑ์ ์ํด `Models` , `View`, `ViewModel` ํด๋๋ฅผ ์์ฑํฉ๋๋ค. 
 2. View ๊ตฌ์ฑ : [MainWindow.xaml](./WPF-MVVM/View/MainWindow.xaml), [MainWindow.xaml.cs](./WPF-MVVM/View/MainWindow.xaml.cs) ํ์ผ์ `View` ํด๋๋ก ์ด๋ํฉ๋๋ค.
    * [App.xaml](./WPF-MVVM/App.xaml)์ `StartupUri` ์์ฑ์ "View/MainWindow.xaml" ๋ก ์์ ํฉ๋๋ค.
 3. ViewModel ๊ตฌ์ฑ : `ViewModel` ํด๋์ [AppViewModel.cs](./WPF-MVVM/ViewModel/AppViewModel.cs), [AppNotify.cs](./WPF-MVVM/ViewModel/AppNotify.cs) ํ์ผ์ ์์ฑํ๊ณ   `Command` ํด๋๋ฅผ ์์ฑํฉ๋๋ค.
 4. [๋น๊ณ ](#MVVM-๊ด๊ณ)์ ๊ฐ์ด ๋ฐ์ธ๋ฉํ์ฌ `View(MainWindow)` ์ `ViewModel(AppViewModel)` ์ฐ๊ฒฐํฉ๋๋ค.
 5. [AppNotify](#INotifyPropertyChanged)์ Binding์ ์ด์ฉํ  ์์ฑ(Property)๋ฅผ ์ ์ํฉ๋๋ค.
    * ๊ฐ์ด ๋ณ๊ฒฝ๋๋ฉด OnPropertyChanged("PropertyPath")๋ฅผ ํธ์ถํ๋ฉฐ ์ด๋ฒคํธ๋ฅผ ๋ฐ์์ํต๋๋ค.
    * ๋ฐ์ธ๋ฉ ์๋ฐ์ดํธ ์กฐ๊ฑด์ ์ด์ฉ๋ฉ๋๋ค.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
 6. Command๋ฅผ ์ด์ฉํ์ฌ Button Click ์ด๋ฒคํธ๋ฅผ ๋์ฒดํฉ๋๋ค.
    * [AppCommand](./WPF-MVVM/ViewModel/Command/AppCommand.cs)๋ฅผ ํํ๋ฆฟ์ผ๋ก ์ด์ฉํ์ฌ ํ์ฉํฉ๋๋ค.
    * [ViewModel](./WPF-MVVM/ViewModel/AppViewModel.cs)์ [AppCommand](./WPF-MVVM/ViewModel/Command/AppCommand.cs) ํ์์ ์์ฑ์ ์ ์ํฉ๋๋ค.
    * [ViewModel](./WPF-MVVM/ViewModel/AppViewModel.cs) ์์ฑ์์์ [AppCommand](./WPF-MVVM/ViewModel/Command/AppCommand.cs)๋ฅผ ์ด๊ธฐํ ํฉ๋๋ค. 
        * `AppCmd = new AppCommand(Command๊ฐ ํธ์ถ๋๋ฉด ์คํํ  ๋ฉ์๋)`
 7. Model ๊ตฌ์ฑ : [Model](./WPF-MVVM/Models/Context.cs) (๋ฐ์ดํฐ๋ฒ ์ด์ค ์ ๊ทผ ํด๋์ค)๋ฅผ [ViewModel](./WPF-MVVM/ViewModel/AppViewModel.cs)์์ ์ฌ์ฉํฉ๋๋ค.

## ๐ป ๊ฐ๋ฐ ํ๊ฒฝ(Develop Environment)

### ์ธ๋ถ ํ๊ฒฝ(Environment Detail)

* โ OS : ![Windows](https://img.shields.io/badge/Windows-0078D6?style=flat-square&logo=Windows&logoColor=white)
  * ๐ Version : `10 Pro 21H2`
* โ Language : ![C#](https://img.shields.io/badge/CSharp-239120?style=flat-square&logo=C-Sharp&logoColor=white)
* โ Dependency : ![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=.NET&logoColor=white)
  * ๐ Version : `6.0`

## ๐ ๋น๊ณ (Remark)

### INotifyPropertyChanged

* ์์ฑ(`Property`)์ ๊ฐ ๋ณ๊ฒฝ์ ๊ฐ์งํ์ฌ ์ด๋ฒคํธ๋ฅผ ๋ฐ์์ํค๋ ์ญํ ์๋๋ค.
* `OnPropertyChanged(string Message)` ๋ฐ์ธ๋ฉ ์ `PropertyPath`๋ก ์ด์ฉ๋ฉ๋๋ค.

### MVVM ๊ด๊ณ

![MVVM](./Image/MVVM.png)
