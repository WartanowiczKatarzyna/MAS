MP1 - wymagania:

* Ekstensja: np. PersonExtent, w osobnym pliku, bo zamierzam użyć ten kod w projekcie, który będzie korzystał z bazy danych
* Ekstensja - trwałość: np. w PersonExtent metody ReadToJsonFile i WriteToJsonFile, zapisywanie do plików JSON ze względu na wygodę, 
pliki znajduja się w folderze JsonFiles w folderze z plikiem wykoywalnym
* Atr. złożony: np. Address w klasie Person
* atr. opcjonalny: np. Street w klasie Address, opcjonalny ze względu na wsie, które nie mają ulic
* atr. powtarzalny: np. _persons w klasie PersonExtent
* atr. klasowy: np. _persons w klasie PersonExtent (atr. klasowy dla klasy Person, który znajduje sie w ekstensji)
* met. klasowa: np. showExtent w klasie PersonExtent (met. klasowa dla klasy Person, która znajduje sie w ekstensji) lub PersonExtent.ReadFromJsonFile()
* przesłonięcie: np. ToString() w klasie Person
* przeciążenie: np. PersonExtent.ReadFromJsonFile() i PersonExtent.ReadFromJsonFile(string name)

MP2 - wymagania:

* asocjacja zwykła
* asocjacja z atrybutem
* asocjacja kwalifikowana
* kompozycja