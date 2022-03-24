# FilEdge: A file-search visualizer desktop app

> Program visualisasi pencarian file memanfaatkan algoritma BFS/DFS dalam bentuk _desktop app_
> > _Tugas Besar 2 IF2211 Strategi Algoritma_ <br> _Pengaplikasian Algoritma BFS dan DFS dalam Implementasi Folder Crawling_ <br> _Semester II 2021/2022_ <br>

## Table of Contents
- [Deskripsi Singkat](#deskripsi-singkat)
- [_Requirements_](#requirements)
- [Kompilasi](#kompilasi)
- [Cara Menggunakan](#cara-menggunakan)
- [Identitas](#identitas)

## Deskripsi Singkat
_FilEdge_ adalah suatu aplikasi _desktop_ untuk melakukan pencarian suatu _file_ dalam direktori. _FilEdge_ dibuat menggunakan bahasa C# (.NET Framework 6.0) dalam bentuk _desktop app_ untuk melakukan visualisasi pencarian suatu _file_ dengan nama tertentu dalam direktori. Aplikasi ini memanfaatkan algoritma BFS (_breadth first search_) dan DFS (_depth first search_) untuk membentuk suatu pohon pencarian terhadap suatu _file_. Dengan menggunakan _FilEdge_, kita cukup memasukkan query pada kotak pencarian sehingga dapat ditemukan suatu file terhadap _query_ yang diisikan.

_FilEdge_ diimplementasikan dengan teknik folder crawling, di mana mesin komputer akan mulai 
mencari file yang sesuai dengan query mulai dari starting directory hingga seluruh children dari 
starting directory tersebut sampai satu file pertama/seluruh file ditemukan atau tidak ada file yang 
ditemukan. Algoritma yang dapat dipilih untuk melakukan crawling tersebut pun dapat bermacam-macam dan setiap algoritma akan memiliki teknik dan konsekuensinya sendiri. Oleh karena itu, 
penting agar komputer memilih algoritma yang tepat sehingga hasil yang diinginkan dapat 
ditemukan dalam waktu yang singkat.

![image](https://user-images.githubusercontent.com/71161031/159916518-12d69146-8420-4834-97a4-a19541094391.png)

## Requirements
- .NET Framework (disarankan 6.0, dapat diunduh di <a href = "https://dotnet.microsoft.com/en-us/download/dotnet/6.0"><b>tautan ini</b></a>
- **[OPTIONAL]** Visual Studio, apabila ingin melakukan _debug build_, dapat diunduh di <a href = "https://visualstudio.microsoft.com/vs/community/"><b>tautan ini</b></a>

## Kompilasi
### Dari folder `bin`
1. Navigasi ke folder `bin`
2. Jalankan `setup.exe`, lalu pada menu instalasi, pilih opsi `Install`
3. Instalasi akan berjalan dan aplikasi akan dilakukan

### **[OPTIONAL]** _Debug Build_ dari _Visual Studio_
1. Buka aplikasi _Visual Studio_, lalu buka _solution file_ `DirectoryTraversal.sln` di direktori `~/Tubes2_13520103/src/`
2. Pada _Solution Explorer_, pastikan _project_ `DirectoryTraversal.GUI` sudah tercetak tebal

 ![image](https://user-images.githubusercontent.com/71161031/159917540-7c42e0e2-0f37-4ad7-a4ac-08ee0849f8b8.png)
 > Apabila belum, klik kanan pada _project_ `DirectoryTraversal.GUI` ->  **_Set as Startup Project_**
3. Lakukan _debug build_ dengan menekan F5 atau menggunakan tombol ini di _toolbar_:

![image](https://user-images.githubusercontent.com/71161031/159918206-614cdca6-e2bc-4684-a435-6ea9a3dbfc39.png)

## Cara Menggunakan
![image](https://user-images.githubusercontent.com/71161031/159918366-97c86c89-0b25-405d-b3ab-612356cd2ff1.png)
- _Choose Starting Directory_: Pengguna dapat memilih direktori awal pencarian
- _Input File Name_: Pengguna memasukkan nama _file_ yang hendak dicari
  - _Find all occurences_: Apabila dicentang, pencarian akan dilakukan dengan mencari semua _file_ dengan nama yang sama di direktori tersebut. Apabila tidak dicentang, pencarian akan berhenti apabila _file_ pertama dengan nama yang sesuai ditemukan.   
  - **[IMPORTANT]** Jangan lupa menyertakan ekstensi _file_ yang hendak dicari!
- _Input Search Method_: Pengguna memilih algoritma pencarian yang ingin digunakan  
  - BFS (_Breadth First Search_): Pencarian mengutamakan pengunjungan direktori secara merata
  - DFS (_Depth First Search_): Pencarian mengutamakan eksplorasi _folder_ yang ditemukan satu per satu
- _Input Drawing Delay_: Pengguna memilih delay antar penggambaran pada panel
- _Search_: Mulai pencarian!

![image](https://user-images.githubusercontent.com/71161031/159918930-a3a49c22-411f-44f8-b3e5-8d882273298e.png)
Hasil pencarian berupa:
- Informasi tentang waktu pencarian
  > **[IMPORTANT]** Waktu pencarian termasuk waktu penggambaran animasi
- Keterangan jumlah file yang ditemukan 
- _Hyperlink_ menuju direktori _file_ tersebut

Miscs: Apabila menggunakan tanda gerigi di _sidebar_, pengguna dapat menggunakan _dark mode._
  > _Hal ini, tentunya, untuk mempermudah pengembangan dan penggunaan di malam hari._

## Identitas
Dibuat oleh Kelompok 42 - Dennis First Search
- Amar Fadil (13520103) <a href="https://github.com/marfgold1">GitHub</a>
- Owen Christian Wijaya (13520124) <a href="https://github.com/clumsyyyy">GitHub</a>
- Fachry Dennis Heraldi (13520139) <a href="https://github.com/dennisheraldi">GitHub</a>
