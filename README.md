# FilEdge: A file-search visualizer desktop app

> Program visualisasi pencarian file memanfaatkan algoritma BFS/DFS dalam bentuk _desktop app_
> > _Tugas Besar 2 IF2211 Strategi Algoritma_ <br> _Pengaplikasian Algoritma BFS dan DFS dalam Implementasi Folder Crawling_ <br> _Semester II 2021/2022_ <br>

## Table of Contents
- [General Information](#general-information)
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Usage](#usage)
- [Contact](#contact)

## General Information
<p> Pada saat kita ingin mencari file spesifik yang tersimpan pada komputer kita, seringkali task tersebut membutuhkan waktu yang lama apabila kita melakukannya secara manual. Bukan saja harus membuka beberapa folder hingga dapat mencapai directory yang diinginkan, kita bahkan dapat lupa di mana kita meletakkan file tersebut. Sebagai akibatnya, kita harus membuka berbagai folder secara satu persatu hingga kita menemukan file yang diinginkan. Hal ini pastinya akan sangat memakan waktu dan energi. 

Meskipun demikian, kita tidak perlu cemas dalam menghadapi persoalan tersebut sekarang. 
Pasalnya, hampir seluruh sistem operasi sudah menyediakan fitur search yang dapat digunakan 
untuk mencari file yang kita inginkan. Kita cukup memasukkan query atau kata kunci pada kotak 
pencarian, dan komputer akan mencarikan seluruh file pada suatu starting directory (hingga 
seluruh children-nya) yang berkorespondensi terhadap query yang kita masukkan. 
  
Fitur ini diimplementasikan dengan teknik folder crawling, di mana mesin komputer akan mulai 
mencari file yang sesuai dengan query mulai dari starting directory hingga seluruh children dari 
starting directory tersebut sampai satu file pertama/seluruh file ditemukan atau tidak ada file yang 
ditemukan. Algoritma yang dapat dipilih untuk melakukan crawling tersebut pun dapat bermacam-macam dan setiap algoritma akan memiliki teknik dan konsekuensinya sendiri. Oleh karena itu, 
penting agar komputer memilih algoritma yang tepat sehingga hasil yang diinginkan dapat 
ditemukan dalam waktu yang singkat
</p>

## Technologies Used

### Languages
- C# (.NET Framework 6.0)

### Frameworks / Libraries
- _Microsoft Automatic Graph Layout_ (MSAGL)
- _MaterialSkin.2_ (bagian front-end)

## Features

Fitur yang dihadirkan oleh aplikasi ini adalah:
- Melakukan visualisasi pencarian diagram dalam _Breadth First Search / Depth First Search_
- Pengaturan jangka animasi untuk visualisasi (25 ms - 500 ms per frame)
- Menampilkan _tree_ hasil pencarian _file_ beserta _hyperlink_ lokasi _file_ tersebut
- Fitur antarmuka dalam mode _light/dark_
- Antarmuka _dark mode_


## Usage
[TO BE ADDED]

## Contact

Dibuat oleh Kelompok 42 - Dennis First Search
- Amar Fadil (13520103) <a href="https://github.com/marfgold1">GitHub</a>
- Owen Christian Wijaya (13520124) <a href="https://github.com/clumsyyyy">GitHub</a>
- Fachry Dennis Heraldi (13520139) <a href="https://github.com/dennisheraldi">GitHub</a>
