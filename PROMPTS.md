# LLM Kullanım Dokümantasyonu

> Bu dosyayı case boyunca kullandığınız LLM (ChatGPT, Claude, Copilot vb.) etkileşimlerini belgelemek için kullanın.
> Dürüst ve detaylı dokümantasyon beklenmektedir.

## Özet

| Bilgi | Değer |
|-------|-------|
| Toplam prompt sayısı | 13 |
| Kullanılan araçlar | Copilot |
| En çok yardım alınan konular | [DEBUG&DOCUMENT-COMMENT GENERATION] |
| Tahmini LLM ile kazanılan süre | 2 saat |

---

## Prompt 1: [GITIGNORE]

**Araç:** [Cursor]

**Prompt:**
```
[git ignore ekler misin]
```

**Alınan Cevap (Özet):**
```
[Genel: *.log, logs/, geçici klasörler (tmp/, temp/), Thumbs.db, .DS_Store.
Node/JS için: node_modules/, dist/, build/, out/, çeşitli *-debug.log dosyaları.
Test / coverage: coverage/.
Ortam dosyaları: .env, .env.*, .env.local, .env.*.local.
IDE / editör: .idea/, .vscode/, *.swp, *.swo.
Diğer: *.bak, *.tmp.
İstersen hangi teknoloji stack’ini kullandığını söylersen, ona özel eklemeler (örneğin Python, .NET, Java vs.) de yapabilirim.]
```

**Nasıl Kullandım:**
- [] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [x] Reddettim (kullanmadım)

**Açıklama:**
> [Gitignore u elimle yazmak istemedim
> projede bulunmayan dosyalarla oluşturmuştu gitignore u]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---

## Prompt 2: [GITIGNORE]

**Araç:** [Cursor]

**Prompt:**
```
[projem unity projesi ona göre bir gitignore ekle]
```

**Alınan Cevap (Özet):**
```
[Neler dahil?
Unity klasörleri: [Ll]ibrary/, [Tt]emp/, [Oo]bj/, [Bb]uild/, [Bb]uilds/, [Ll]ogs/, [Uu]ser[Ss]ettings/, [Mm]emoryCaptures/, [Rr]ecordings/.
IDE / proje dosyaları: *.csproj, *.sln, *.user, *.pidb, *.pdb, *.opendb, Rider için .idea/, VS Code için .vscode/.
Build çıktıları: *.apk, *.aab, *.unitypackage.
OS ve geçici dosyalar: .DS_Store, Thumbs.db, *.log, *.bak, *.tmp ve .env türevleri.
İstersen VR, mobil veya WebGL’e özel ekstra klasörler varsa onları da ayrıca ekleyebiliriz.]
```

**Nasıl Kullandım:**
- [X] Direkt kullandım
- [ ] Adapte ettim
- [ ] Reddettim

**Açıklama:**
> [Gitignore u kendim yazmak istemedim]

---

## Prompt 3: [Proje yardımı]

**Araç:** [Cursor]

**Prompt:**
```
[docstaki mdleri okuyup bana biraz anlatabilir misin kendim okudum da açıklama da istiyorum]
```

**Alınan Cevap (Özet):**
```
[Genel: Genel olarak projeyi nasıl yapabileceğim mimariler hakkında bilgi verdi]
```

**Nasıl Kullandım:**
- [] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [x] Reddettim (kullanmadım)

**Açıklama:**
> [Çok uzun geldiği ve sadece biraz fikir almak için sorduğumdan hepsini okumadım
> ]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 4: [GITIGNORE]

**Araç:** [Cursor]

**Prompt:**
```
[IInteractable.cs i interface olarak nasıl kullanabilirim]
```

**Alınan Cevap (Özet):**
```
[Genel:Interface nasıl kullanılır ve InteractionDetector de raycast nasıl kullanılır fikir verdi ]
```

**Nasıl Kullandım:**
- [] Direkt kullandım (değişiklik yapmadan)
- [x] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Gitignore u elimle yazmak istemedim
> projede bulunmayan dosyalarla oluşturmuştu gitignore u]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 5: [Namespace]

**Araç:** [Cursor]

**Prompt:**
```
[Assets\Scripts\Runtime\Player\InteractionDetector.cs(23,13): error CS0246: The type or namespace name 'IInteractable' could not be found (are you missing a using directive or an assembly reference?)
böyle bir hata alıyorum]
```

**Alınan Cevap (Özet):**
```
[Genel: Bu hatanın sebebi, InteractionDetector içinde IInteractable’ın namespace’ini eklememiş olmandı.
Şu değişiklikleri yaptım:
Namespace ekledim: Dosyanın başına using Runtime.Core; ekledim, böylece IInteractable tipi tanınır hale geldi.
Field’ı düzelttim:
const alanlar serialize edilemez; [SerializeField] private const float k_InteractionRange = 2f; yerine
CSharp_Coding_Conventions’a uygun olarak [SerializeField] private float m_InteractionRange = 2f; yaptım ve raycast’te bunu kullanıyorum.
Şu anda IInteractable tipi tanınmalı; Unity’de yeniden compile ettiğinde CS0246 hatası gitmiş olmalı. Eğer istersen DetectInteractables içinde interactable.Interact(); çağrısını da birlikte ekleyip tamamlayabiliriz.]
```

**Nasıl Kullandım:**
- [x] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Interface kullanımını unuttuğum için namespace i nasıl kullanmam gerektiğini hatırladım
> ]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 6: [GITIGNORE]

**Araç:** [Cursor]

**Prompt:**
```
[175-180 arası terminal çıktısı]
```

**Alınan Cevap (Özet):**
```
[.vs/ klasörü artık git tarafından görmezden geliniyor. .gitignore'a ekledim, bu yüzden git onu izlemiyor.
Yaptığım değişiklik:
.gitignore dosyasına .vs/ satırını ekledim (Visual Studio cache klasörü)
Şimdi yapabileceklerin:
git add . veya git add <dosya> komutunu çalıştırabilirsin; .vs/ klasörü otomatik olarak atlanacak.
Not: LF/CRLF uyarıları Windows'ta normal; bunlar sadece bilgilendirme, hata değil. Git dosyaları otomatik olarak dönüştürecek.
Başka bir sorun olursa haber ver.]
```

**Nasıl Kullandım:**
- [x] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Git pushuyla ilgili bir sorun yaşıyordum onu sorup düzelttirdim]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 7: [Kod yardımı]

**Araç:** [Cursor]

**Prompt:**
```
[@Assets/Scripts/Runtime/Interactables/Chest.cs  içinde input kesildiği zaman update içinde yaptığı şeyi kesmesini nasıl sağlarım]
```

**Alınan Cevap (Özet):**
```
[1. IInteractable – CancelHold() eklendi
E bırakıldığında detector bu metodu çağırıyor.
Hold kullanmayan (Door, Key, Switch) sınıflarda boş implement yeterli.
2. Chest.cs
Interact(): Hold’u başlatıyor (m_IsInteracting = true, m_InteractTimer = 0).
CancelHold(): E bırakılınca çağrılıyor; m_IsInteracting = false ve m_InteractTimer = 0 ile sayacı sıfırlıyor.
Update: Sadece m_IsInteracting == true iken timer artıyor; E bırakıldığında CancelHold() ile durduğu için ilerleme kesiliyor.
[SerializeField] private const kaldırıldı, m_InteractTime kullanılıyor (Inspector’dan ayarlanabilir).
3. InteractionDetector.cs
m_CurrentHoldTarget: E’ye basıldığında etkileşime girdiğin nesneyi tutuyor.
Input.GetKeyDown(KeyCode.E): Raycast ile hedefi bulup Interact() çağırıyor ve hedefi m_CurrentHoldTarget’a atıyor.
Input.GetKeyUp(KeyCode.E): E bırakıldığında m_CurrentHoldTarget?.CancelHold() çağrılıyor, sonra m_CurrentHoldTarget = null yapılıyor.
Böylece sandığa bakarken E’ye basıp sayacı doldurmadan E’yi bırakırsan, CancelHold() tetiklenir ve Chest’teki Update içindeki ilerleme durur; timer sıfırlanır.]
```

**Nasıl Kullandım:**
- [] Direkt kullandım (değişiklik yapmadan)
- [x] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Hold işinde inputtan elimi çektikten sonra nasıl bir şey yaparım diye bilgi edinmek istedim yazdığı kod pek aklıma yatmadığı için adapte ettim]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [Interfacede yaptığı değişikliği aldım mantık olarak kendimce mantıklı olan şekilde değiştirdim]

---
## Prompt 8: [Fikir]

**Araç:** [Cursor]

**Prompt:**
```
[kapı anahtar switchleri birbirine bağlamak için fikir verir misin tagle bağlamak mantıklı mı]
```

**Alınan Cevap (Özet):**
```
[Pratik öneri (case’e uyumlu)
Kapı – Anahtar: ScriptableObject ile “anahtar/kilit tipi” tanımla; kapı ve anahtar item’ı bu tip üzerinden eşleşsin. Tag kullanma.
Switch – Kapı: Ya [SerializeField] Door m_DoorToToggle gibi tek referans, ya da UnityEvent ile Inspector’dan bağla. Tag ile “hangi kapı” demeye çalışma.
İstersen bir sonraki adımda ScriptableObject key type yapısını veya Switch’in UnityEvent ile nasıl bağlanacağını adım adım (kod örnekleriyle) çıkarabilirim; bunu Agent modunda proje dosyalarına uyarlayarak da yapabilirim.]
```

**Nasıl Kullandım:**
- [x] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Aklımda linklemek için fikir vardı ama tag ile kontrol etmek iyi bir fikir mi diye sordum gelen cevaba göre ilerledim]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 9: [ScriptableObject yardımı]

**Araç:** [Cursor]

**Prompt:**
```
[scritpable object nasıl yazılır örnek verir misin]
```

**Alınan Cevap (Özet):**
```
[Genel: Özet: ScriptableObject = Script’ten türet + CreateAssetMenu + public/SerializeField alanlar. Asset’i Create ile oluşturup, kapı/anahtar script’lerinde [SerializeField] KeyType ile referans verirsin.]
```

**Nasıl Kullandım:**
- [x] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Verdiği kodu alıp kullanmak istedim kodda çalıştırdıktan sonra da pek üstünde oynamadım]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 9: [DEBUG]

**Araç:** [Cursor]

**Prompt:**
```
[ilk Interact ettiğim objede takılı kalıyor neden]
```

**Alınan Cevap (Özet):**
```
[1. E bırakıldığında referans temizlenmiyordu
GetKeyUp içinde CancelInteract() çağrılıyordu ama m_currentInteractable = null yapılmıyordu. Bu yüzden hep ilk etkileştiğin obje referansı kalıyordu.
→ E bırakıldığında artık m_currentInteractable = null atanıyor.
2. Yeni E basışında hedef güncellenmiyordu
DetectInteractables() içinde sadece m_currentInteractable == null iken atama vardı. İkinci kez E’ye basınca yeni objeyi buluyordu ama m_currentInteractable hâlâ ilk obje olduğu için m_currentInteractable.Interact() yine ilk objeyi tetikliyordu.
→ Artık her E basışında raycast’le bulunan interactable hem m_currentInteractable’a atanıyor hem de interactable.Interact() çağrılıyor; yani her seferinde baktığın obje ile etkileşim oluyor.
Bu iki değişiklikle ilk objede takılı kalma sorunu giderilmiş olmalı.]
```

**Nasıl Kullandım:**
- [x] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Tek satır değiştirmek gerekiyormuş null kontrolüne dikkat etmemişim ]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 9: [Lerp yardım]

**Araç:** [Cursor]

**Prompt:**
```
[bir objeye lerpi nasıl uygularım kapının yavaş yavaş dönerek açılmasını istiyorum]
```

**Alınan Cevap (Özet):**
```
[Eklenen / değişen mantık
m_ClosedRotation – Start()’ta mevcut rotasyon (kapalı açı) kaydediliyor.
m_OpenRotation – Kapalı rotasyon + Y’de m_OpenAngleY (varsayılan 90°) ile hesaplanıyor.
m_TargetRotation – Gidilecek açı; Interact() ile aç/kapa arasında değişiyor.
Update() – Her frame Quaternion.Slerp(mevcut, m_TargetRotation, m_RotationSpeed * Time.deltaTime) ile rotasyon güncelleniyor; kapı yavaşça dönüyor.
Inspector
Open Angle Y: Açıkken eklenen Y açısı (derece).
Rotation Speed: Dönüş hızı (büyüdükçe daha hızlı).
Ek olarak: Kilit kontrolü item is Key key && key.KeyType == m_RequiredKeyType ile yapılıyor, Inventory.Instance.items kullanılıyor ve gereksiz using’ler kaldırıldı. Artık kapı açılıp kapanırken yumuşak bir dönüş göreceksin; hızı Inspector’dan Rotation Speed ile ayarlayabilirsin.]
```

**Nasıl Kullandım:**
- [] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [x] Reddettim (kullanmadım)

**Açıklama:**
> [Lerp kullanmak istediğim şeyi yapmıyordu reddettim]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---
## Prompt 9: [Kamera döndürme yardımı]

**Araç:** [Cursor]

**Prompt:**
```
[Rotate yaparken ekran yamuluyo neyi düzeltmek lazım]
```

**Alınan Cevap (Özet):**
```
[Neden yamuluyordu?
İki ayrı Rotate() ile önce Y (yaw), sonra X (pitch) uygulanıyordu. Unity bunu Euler açılarıyla birleştirince roll (Z dönüşü) oluşuyordu; ekran yan yatıyormuş gibi görünüyordu.
Yukarı/aşağı bakınca gimbal lock (özellikle ±90° civarı) da ek sıçrama/yamulama yapabiliyordu.
Yapılan düzeltmeler
Yaw ve pitch ayrı tutuluyor
m_Yaw ve m_Pitch değişkenleri var; mouse ile sadece bunlar güncelleniyor.
Tek rotasyon, roll = 0
Her frame’de tek seferde:
transform.rotation = Quaternion.Euler(m_Pitch, m_Yaw, 0f);
Böylece Z açısı hep 0; yan yatma (yamulama) kalkıyor.
Pitch sınırlandı
m_Pitch m_PitchMin / m_PitchMax (varsayılan -80° / 80°) ile clamp ediliyor; tam dik bakınca gimbal lock olmuyor.
Inspector’dan ayar
m_MovementSpeed, m_MouseSensitivity, m_PitchMin, m_PitchMax Inspector’dan değiştirilebilir (Ludu convention için m_ ve [SerializeField] kullanıldı; const kaldırıldı).
Bu haliyle dönüş sırasında ekranın yamulaması durmalı. Hâlâ yamulama varsa, kamera başka bir objenin child’ı mı (örn. boş bir “CameraHolder”) kontrol et; rotasyonu sadece bu script’in olduğu objede uyguluyoruz.]
```

**Nasıl Kullandım:**
- [] Direkt kullandım (değişiklik yapmadan)
- [x] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [3D oyunda kamera optimizsayonu nasıl yapıldığını bilmediğimden ve süremin sonuna yaklaştığımdan kodu alıp kullandım istenen şekle getirilerek]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [Sabit sayılar kullandığı için değişkenlere atadım]

---
## Prompt 9: [ScriptableObject yardımı]

**Araç:** [Cursor]

**Prompt:**
```
["Bu kodu Ludu Arts C# convention'larına göre refactor et:
   - m_ prefix kullan
   - Region'ları ekle
   - XML documentation ekle"]
```

**Alınan Cevap (Özet):**
```
[Ludu Arts C# convention refactor özeti
1. m_ prefix
Tüm private alanlar m_ ile: m_MainCamera, m_CurrentInteractable, m_IsLocked, m_KeyType, m_IsInteracting, m_InteractTimer, m_Items, m_InteractionPromptText vb.
Chest’te isInteracting / interactTimer → m_IsInteracting / m_InteractTimer.
Sabitler k_ ile kaldı: k_InteractionRange, k_InteractTime vb.
2. Region’lar (CSharp_Coding_Conventions sırası)
Fields → Unity Methods → Methods → Interface Implementations (ve gerektiğinde Properties) kullanıldı.
InteractionDetector, PlayerMovement, Inventory, Door, Key, Switch, Chest, InteractionPrompt hepsinde bu yapı var.
3. XML documentation
Public class’lar: <summary> ile kısa açıklama.
Public / interface metodları: <summary>, gerektiğinde <param>, <returns>.
Interface implementasyonlarında /// <inheritdoc /> kullanıldı.
IInteractable, KeyType ve tüm MonoBehaviour script’lerinde public API’ler belgelendi.
4. Diğer düzenlemeler
Inventory: public List<> items → [SerializeField] private List<> m_Items + public property Items; kullanımlar Inventory.Instance.Items olacak şekilde güncellendi (Door zaten Items kullanıyor).
IInteractable: CancelInteract() için default implementation kaldırıldı; tüm implementasyonlarda açık CancelInteract() var.
Null / convention: Gerekli yerlerde null kontrolleri ve Debug.LogWarning eklendi (Inventory.AddItem, InteractionPrompt, Door Awake, Key Start, Chest Update).
Gereksiz using’ler kaldırıldı (Door: Unity.VisualScripting, System; Key: UnityEngine.Timeline).
Unity’de projeyi açıp derleyerek kontrol edebilirsin; lint tarafında hata görünmüyor. Inspector’da Inventory için önceden “items” listesine atanmış referans varsa, artık “Items” / m_Items alanına bakıldığından listeyi oradan doldurman gerekebilir.]
```

**Nasıl Kullandım:**
- [x] Direkt kullandım (değişiklik yapmadan)
- [ ] Adapte ettim (değişiklikler yaparak)
- [] Reddettim (kullanmadım)

**Açıklama:**
> [Case in son dakikalarıydı ve interaction systemde aynı prompt olduğu için kullanıp halletmek istedim]

**Yapılan Değişiklikler (adapte ettiyseniz):**
> [LLM cevabını nasıl değiştirdiğinizi açıklayın]

---



## Genel Değerlendirme

### LLM'in En Çok Yardımcı Olduğu Alanlar
1. [Debug]
2. [Comment]
3. [Bilmediğim sistemler]

### LLM'in Yetersiz Kaldığı Alanlar
1. [-]

### LLM Kullanımı Hakkında Düşüncelerim
> [LLM sadece hızlandırdı beni ama kamera optimizasyonunu nasıl yapmam gerektiğini dosyalar arası geçişleri daha rahat nasıl yapabilirim onu öğrendim
> 3-4 gün
> Kendimi geliştirdikçe sorabileceğim soru sayısı artacağı için daha etkili kullanabilirim]

---

## Notlar

- Her önemli LLM etkileşimini kaydedin
- Copy-paste değil, anlayarak kullandığınızı gösterin
- LLM'in hatalı cevap verdiği durumları da belirtin
- Dürüst olun - LLM kullanımı teşvik edilmektedir

---

*Bu şablon Ludu Arts Unity Intern Case için hazırlanmıştır.*
