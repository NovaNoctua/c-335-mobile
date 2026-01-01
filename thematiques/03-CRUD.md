# CRUD

![crud.png](assets/crud.png)

La partie MVVM/EF est donnée à titre informatif et optionnel.

## Version Code behind

### Théorie

#### Supports
- [CRUD](../supports/08a-crud.md)

#### Slides

### Activités

### Synthèse

## Version MVVM/EF (avancé, optionnel)

### Théorie MVVM

#### Supports MVVM
- [MVVM](../supports/05b-mvvm.md)
- [CRUD MVVM](../supports/08b-crud.md)
- [SQLITE](../supports/09-db.md)

##### Références EF
- [EntityFramework (Persistence)](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)

#### Slides MVVM
- [CRUD](https://eduvaud-my.sharepoint.com/:p:/g/personal/jonathan_melly_eduvaud_ch/ERG7KDRhoelFngBf9bRbnaEBxp9S0o-PUCQsgBMa3XQ8Yg?e=qPaylv)
- [MVVM](https://eduvaud-my.sharepoint.com/:p:/g/personal/jonathan_melly_eduvaud_ch/ET-n9RZYpktFskQ8Il9xQv4BsRxezaKL-ILDp--AJ0BukA?e=z4tA27)
- [SQLite](https://eduvaud-my.sharepoint.com/:p:/g/personal/jonathan_melly_eduvaud_ch/EfOweX5hs5tHjqPIIcnxFxoBBqo_BYbszqYmy1xFYpGOSw?e=yvZ0gz)

### Activités MVVM
1. [ ] [MVVM](https://labs.section-inf.ch/codelabs/mobile-03-mvvm1/index.html?index=..%2F..index)
2. [ ] [ListView **C**reate**R**ead](https://labs.section-inf.ch/codelabs/mobile-04-mvvm2/index.html?index=..%2F..index)
3. [ ] [**U**pdate**D**elete > Persistence](https://labs.section-inf.ch/codelabs/mobile-05-crud1/index.html?index=..%2F..index)

### Synthèse MVVM
- [Récap 1](https://eduvaud.sharepoint.com/:p:/s/msteams_d0db31/Edir3t8BDNJEhNummU3KMxYBymZeN2Agw4agnx3gO6t6Gw?e=XApwi3)


## Bug du scroll d'une collectionView
- Avec MAUI8, il fallait ajouter "FillAndExpand" et avec MAUI9, il faut définir un "HeightRequest" dans le composant "CollectionView".
[Référence](https://learn.microsoft.com/en-us/answers/questions/1200032/collectionview-cant-scroll)
