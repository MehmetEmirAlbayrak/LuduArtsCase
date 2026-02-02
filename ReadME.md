# Interaction System - [Mehmet Emir Albayrak]

> Ludu Arts Unity Developer Intern Case

## Proje Bilgileri

| Bilgi | Değer |
|-------|-------|
| Unity Versiyonu | 6000.2.5f1|
| Render Pipeline | Built-in / URP / HDRP |
| Case Süresi | 12 saat |
| Tamamlanma Oranı | %70 |

---

## Kurulum

1. Repository'yi klonlayın:
```bash
git clone https://github.com/MehmetEmirAlbayrak/LuduArtsCase
```

2. Unity Hub'da projeyi açın
3. `Assets//Scenes/TestScene.unity` sahnesini açın
4. Play tuşuna basın

---

## Nasıl Test Edilir

### Kontroller

| Tuş | Aksiyon |
|-----|---------|
| WASD | Hareket |
| Mouse | Bakış yönü |
| E | Etkileşim |
| [Diğer] | [Açıklama] |

### Test Senaryoları

1. **Door Test:**
   - Kapıya yaklaşın, "Press E to Open" mesajını görün
   - E'ye basın, kapı açılsın

2. **Key + Locked Door Test:**
   - Kilitli kapıya yaklaşın, E ile etkileşime geçebileceğiniz mesajını görün ve kapıyı açamayın
   - Anahtarı bulun ve toplayın
   - Kilitli kapıya geri dönün, şimdi açılabilir olmalı

3. **Switch Test:**
   - Switch'e yaklaşın ve aktive edin
   - Bağlı nesnenin (kapı/ışık vb.) tetiklendiğini görün

4. **Chest Test:**
   - Sandığa yaklaşın
   - E'ye basılı tutun
   - Sandık açılsın ve içindeki item alınsın

---

## Mimari Kararlar
Anahtarların kapıyı tanıması için KeyType ile ayırt ediyorum kapı ve anahtar rengi de ona göre uyumlanıyor. Switch ise hangi kapıyı açması gerektiğini alıyor ve onunla interact a geçiyor. Ray ile objeyi bulup bulduğum objeye interact ediyorum. karakter olarak kamerayı kullanıyorum kamera hareket ediyor ve belli açılara bakabiliyorum.

### Interaction System Yapısı

```
IInteractableda olan fonksiyonlar 4 ayrı interactables a dağılıyor ve hepsi kendi içinde yapması gereken implementasyonlara sahip. Raycast ile uzaklığa bağlı olarak bulduğum interactables objeleri IInteractableda olan interact fonksiyonunu çağırıyor. Chest için de exit interaction eklemem gerekti çünkü e den elimi çektiğimi belirtmem gerekiyordu ve UI için de string dönen 3 fonksiyon var onları doğru zamanda ekrana bastırıyorum
```

**Neden bu yapıyı seçtim:**
> Raycast ile önümdeki objeyi alıp interactable olarak çağırabilmem temiz olduğu için bu yapıyı seçtim.

**Alternatifler:**
> Aklıma önümdeki objeyi alabilmek için Raycastten daha iyi bir yol gelmedi.

**Trade-off'lar:**
> -

### Kullanılan Design Patterns

| Pattern | Kullanım Yeri | Neden |
|---------|---------------|-------|
| [Singleton] | [UI, Inventory] | [Bu objelerden 1 tane var ve her yerden rahat erişebilmem gerekiyor] |

---

## Ludu Arts Standartlarına Uyum

### C# Coding Conventions

| Kural | Uygulandı | Notlar |
|-------|-----------|--------|
| m_ prefix (private fields) | [x] / [ ] | |
| s_ prefix (private static) | [x] / [ ] | |
| k_ prefix (private const) | [x] / [ ] | |
| Region kullanımı | [x] / [ ] | |
| Region sırası doğru | [x] / [ ] | |
| XML documentation | [x] / [ ] | |
| Silent bypass yok | [x] / [ ] | |
| Explicit interface impl. | [x] / [ ] | |

### Naming Convention

| Kural | Uygulandı | Örnekler |
|-------|-----------|----------|
| P_ prefix (Prefab) | [x] / [ ] | P_Door, P_Chest |
| M_ prefix (Material) | [x] / [ ] | M_Door_Wood |
| T_ prefix (Texture) | [x] / [ ] | |
| SO isimlendirme | [x] / [ ] | |

### Prefab Kuralları

| Kural | Uygulandı | Notlar |
|-------|-----------|--------|
| Transform (0,0,0) | [x] / [ ] | |
| Pivot bottom-center | [x] / [ ] | |
| Collider tercihi | [x] / [ ] | Box > Capsule > Mesh |
| Hierarchy yapısı | [x] / [ ] | |

### Zorlandığım Noktalar
>Genel olarak alışık olduğum bir mimari değildi unity ile tecrübem olmasına rağmen bu kadar ayrık bir mimariyle ilk defa bir proje yapıyorum. Interface kullanmak ve bunları objelere dağıtıp işlem yapmak Javadan alışık olduğum bir şeydi ama uzun süredir kullanmadığım için biraz unutmuştum hatırlarken zorlandım. Objelere raycast atıp onlar üzerinde işlem yapmak ne kadar kolay olsa da her birini ayrı ayrı yapmak epey zamanımı aldı

---

## Tamamlanan Özellikler

### Zorunlu (Must Have)

- [x] / [ ] Core Interaction System
  - [x] / [ ] IInteractable interface
  - [x] / [ ] InteractionDetector
  - [x] / [ ] Range kontrolü

- [x] / [ ] Interaction Types
  - [x] / [ ] Instant
  - [x] / [ ] Hold
  - [x] / [] Toggle

- [x] / [ ] Interactable Objects
  - [x] / [ ] Door (locked/unlocked)
  - [x] / [ ] Key Pickup
  - [x] / [ ] Switch/Lever
  - [x] / [ ] Chest/Container

- [x] / [ ] UI Feedback
  - [x] / [ ] Interaction prompt
  - [x] / [ ] Dynamic text
  - [] / [x] Hold progress bar
  - [x] / [ ] Cannot interact feedback

- [] / [x] Simple Inventory
  - [x] / [ ] Key toplama
  - [] / [x] UI listesi

### Bonus (Nice to Have)

- [x] Animation entegrasyonu
- [ ] Sound effects
- [x] Multiple keys / color-coded
- [ ] Interaction highlight
- [ ] Save/Load states
- [x] Chained interactions

---

## Bilinen Limitasyonlar

### Tamamlanamayan Özellikler
1. [Hold Progress Bar] - [Diğer şeylerle fazla oyalandığım için bakamadım]
2. [Simple Inventory %50] - [Diğer şeylerle fazla oyalandığım için bakamadım]
3. [UI listesi] - [Diğer şeylerle fazla oyalandığım için bakamadım]

### Bilinen Bug'lar
1. [Kapı açılınca collider yer değişmediği için kapının üstünden atlamak gerekiyor ] - [Açık kapıdan yürü]

### İyileştirme Önerileri
1. [Zaman kaybetmek] - [Yetiştiremediğim her şeyi ekleyebilirdim biraz daha zamanım olsaydı daha güzel leveller daha iyi mekanikler ekleyebilirdim]
2. [Bazı mimarileri daha temiz yazabilirdim]

---



## Dosya Yapısı

```
Assets/
├── [ProjectName]/
│   ├── Scripts/
│   │   ├── Runtime/
│   │   │   ├── Core/
│   │   │   │   ├── IInteractable.cs
│   │   │   │   └── ...
│   │   │   ├── Interactables/
│   │   │   │   ├── Door.cs
│   │   │   │   └── ...
│   │   │   ├── Player/
│   │   │   │   └── ...
│   │   │   └── UI/
│   │   │       └── ...
│   │   └── Editor/
│   ├── ScriptableObjects/
│   ├── Prefabs/
│   ├── Materials/
│   └── Scenes/
│       └── TestScene.unity
├── Docs/
│   ├── CSharp_Coding_Conventions.md
│   ├── Naming_Convention_Kilavuzu.md
│   └── Prefab_Asset_Kurallari.md
├── README.md
├── PROMPTS.md
└── .gitignore
```

---

## İletişim

| Bilgi | Değer |
|-------|-------|
| Ad Soyad | [Mehmet Emir Albayrak] |
| E-posta | [mehmetemirr24@gmail.com] |
| LinkedIn | [https://tr.linkedin.com/in/mehmet-emir-albayrak-b47684231] |
| GitHub | [https://github.com/MehmetEmirAlbayrak] |

---

*Bu proje Ludu Arts Unity Developer Intern Case için hazırlanmıştır.*
