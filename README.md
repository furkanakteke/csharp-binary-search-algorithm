# C# Binary Search (İkili Arama) Algoritması

Bu depo, bilgisayar bilimlerinde arama maliyetlerini optimize etmek için kullanılan en temel ve güçlü yaklaşımlardan biri olan **Binary Search (İkili Arama)** algoritmasının C# ile geliştirilmiş temiz bir konsol uygulaması örneğidir.

---

## 🧠 Algoritmanın Çalışma Mantığı

Doğrusal arama (Linear Search) elemanları tek tek kontrol ederken, Binary Search **sıralı bir dizi (Sorted Array)** üzerinde çok daha akıllıca çalışır. Algoritma her adımda arama uzayını yarıya indirir:

1. **Orta Noktayı Bulma:** Dizinin ilk (`kucuk`) ve son (`buyuk`) indekslerinin ortalaması alınarak `orta` eleman tespit edilir.
2. **Kıyaslama:** 
   * Eğer aranan sayı ortadaki elemana **eşitse**, arama başarıyla tamamlanır ve indeks döndürülür.
   * Eğer aranan sayı ortadaki elemandan **küçükse**, dizinin sağ yarısı tamamen elenir ve arama sol yarıda (`buyuk = orta - 1`) devam eder.
   * Eğer aranan sayı ortadaki elemandan **büyükse**, dizinin sol yarısı elenir ve arama sağ yarıda (`kucuk = orta + 1`) devam eder.
3. **Döngü Sonu:** Bu işlem, `kucuk <= buyuk` şartı sağlandığı sürece (arama uzayı tükenene kadar) tekrar eder.

---

## 📊 Zaman Karmaşıklığı (Time Complexity)

* **En Kötü Senaryo (Worst Case):** $O(\log n)$  
  *(Örneğin: 1024 elemanlı sıralı bir dizide, aranan sayı en fazla 10 adımda kesin olarak bulunur veya olmadığı anlaşılır).*
* **En İyi Senaryo (Best Case):** $O(1)$  
  *(Aranan sayının ilk denemede direkt dizinin tam ortasında denk gelmesi durumu).*

---

## 🛠️ Kullanılan Teknolojiler & Yapı

* **Dil:** C#
* **Platform:** .NET / Console Application (Konsol Uygulaması)
* **Geliştirme Ortamı:** Visual Studio

Bu çalışma, büyük veri kümelerinde arama performansını artırmaya yönelik temel algoritma mantığını ve indeks yönetimini somut bir şekilde göstermektedir.
