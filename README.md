# Faiz Hesaplama Aracı

Bu, C# ile basit bir faiz hesaplama aracıdır.

## Kullanım

1. Bu depoyu klonlayın.
2. Proje dizinine gidin.
3. Programı Visual Studio veya herhangi bir C# derleyicisi kullanarak çalıştırın.
4. İstenildiğinde aşağıdaki bilgileri girin:
   - Anapara Miktarı: Yatırılan ilk para miktarı.
   - Faiz Oranı: Yıllık faiz oranı.
   - Stopaj Oranı: Faizden kesilen vergi oranı.
   - Eklenen Miktar: Her ay ana paraya eklenen miktar.
   - Ay Sayısı: Yatırımın süresi (ay cinsinden).
5. Program, her ay için faiz oranını, net miktarı, brüt faizi ve kesilen vergiyi hesaplayacak ve ekrana yazdıracaktır.
6. Yatırım süresinin sonunda toplam tutarı gösterecektir.

## Örnek Çalıştırma

- Anapara: 20000
- Faiz Oranı: 25
- Stopaj Oranı: 15
- Eklenecek Miktar: 1500
- Vade (AY): 6

- Net Para: 20.354,17       1.Ay Faiz: 354,17          Brüt Faiz: 416,67          Stopaj: 62,50
- Net Para: 22.241,17       2.Ay Faiz: 387,00          Brüt Faiz: 455,30          Stopaj: 68,29
- Net Para: 24.161,58       3.Ay Faiz: 420,42          Brüt Faiz: 494,61          Stopaj: 74,19
- Net Para: 26.116,01       4.Ay Faiz: 454,42          Brüt Faiz: 534,62          Stopaj: 80,19
- Net Para: 28.105,04       5.Ay Faiz: 489,03          Brüt Faiz: 575,33          Stopaj: 86,30
- Net Para: 30.129,30       6.Ay Faiz: 524,26          Brüt Faiz: 616,77          Stopaj: 92,52

- Toplam: 30.129,30

## Katkıda Bulunma

Katkılarınızı bekliyoruz! Sorun açabilir veya bir pull request gönderebilirsiniz.
