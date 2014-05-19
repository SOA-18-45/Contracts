Contracts
=======

Pliki z kontraktami należy wklejać do katalogu Contracts/Contracs/
Następnie otwieramy projekt Contracts/Contracts.sln.
Jeśli dodawaliśmy nowy plik z kontraktem wówczas dodajemy go do projektu: Project -> Add existing item.

Tworzymy commit ze zmianami i wysyłamy je (git push) do repozytorium.

**Budowanie Contracts.dll**
 1. Build -> Build Solution (F6)

**Definiowanie referencji do Contracts.dll**
 1. Prawy przycisk myszy na "References"
 2. "Add Reference..."
 3. "Browse"
 4. Namierzamy plik Contracts.dll (Contracts/Contracts/bin/Debug/Contracts.dll)
 5. Dopisujemy do pliku z programem ```using Contracts;```
