# Planering — VR-sportspel i Unity

> **Obligatorisk.** Fyll i hela dokumentet och lämna in det till läraren för godkännande **innan** ni börjar koda.
> Ta bort exempeltexten i kursivt och skriv era egna svar.

---

## 1. Gruppen

| Namn | Klass | Huvudansvar |
|---|---|---|
| Amir | 240s | |
| Kristóf | 240s | |
| Max | 240s | |
| Mattias | 240s | |

**Projektnamn: Skvåsch**

**GitHub-repo (länk): https://github.com/hgmaxdel/S4squash.git**

---

## 2. Spelidé

**Vilken sport har ni valt?**

Squash

**Beskriv spelet i 3–5 meningar. Vad gör spelaren? Vad är målet?**

Spelaren står i ett rum och slår en boll med racket mot väggen. Målet är att fortsätta slå bollen utan miss så många ggr som möjligt.

**Varför är den här sporten lämplig i VR?**

Cool sport, väldigt fysikinteragerande

**Vad gör ert spel roligt? (Vad är "kroken"?)**

Sporten är rolig, därmed spelet.

---

## 3. Skisser

Rita spelplanen, var spelaren står, vad hen ser och hur UI:t ser ut. Handritat och fotograferat går bra — lägg bilderna i mappen `Dokumentation/` och länka till dem här.

- [ ] Skiss: översikt av spelplanen
- [ ] Skiss: vad spelaren ser i headsetet (förstapersonsvy)
- [ ] Skiss: startmeny och poängtavla

*Länkar till bilder:*

![Spelplan](Dokumentation\VR_spelplan.png)
![FPV](Dokumentation\VR_fpv.png)
![Startmeny](Dokumentation\VR_startmeny.png)

---

## 4. Spelmekanik

**Vad kan spelaren göra med händerna?**

Greppa boll, kasta för att starta
Greppa racket för att slå

**Vilka fysikobjekt finns och hur beter de sig?**

| Objekt | Rigidbody? | Collider | Beteende |
|---|---|---|---|
| Boll | Ja | Sphere | Rullar, påverkas av gravitation, studsar |
| Racket | Ja | *nå rect grej* | kan slå bollen |
| | | | |

**Hur räknas poäng? Skriv reglerna tydligt.**

Varje slag med racketet är ett poäng

**Hur vinner eller förlorar man?**

Om bollen studsar en andra gång utan att slås av racketet har man förlorat. Vinst existerar inte utan man jagar highscore

**Hur startas spelet om?**

Plocka upp bollen igen och helt enkelt börja köra igen

---

## 5. Kravlista

Dela upp funktionerna. **Måste** ska vara klart för godkänt — börja alltid med dem.

### Måste (grundkrav)
- [ ] VR-spelare (XR Origin) med fungerande head tracking
- [ ] Spelaren kan greppa och släppa minst ett föremål
- [ ] Träffdetektion som fungerar
- [ ] Poängsystem
- [ ] Vinst-/förlustvillkor
- [ ] Startmeny i World Space
- [ ] Game over-skärm med resultat
- [ ] Ljudeffekter
- [ ] Omstart av spelet
- [ ] Byggbar .apk
- [ ]
- [ ]

### Om vi hinner (extra)
- [ ] Haptisk feedback
- [ ] Bakgrundsmusik / publikljud
- [ ] Highscore som sparas
- [ ] Svårighetsgrader
- [ ] Flera banor / nivåer
- [ ]
- [ ]

---

## 6. Arbetsfördelning

| Område | Ansvarig | Beskrivning |
|---|---|---|
| VR-uppsättning (XR Origin, interaktion) | Kristóf | |
| Spelmekanik och fysik | Max | |
| Poängsystem och regler | Amir | |
| 3D-modeller och miljö | Mattias | |
| UI och menyer | Mattias | |
| Ljud | Max | |
| Testning och bygge | Amir | |

**Hur samarbetar ni i Git?**
Huvudsakligen i main, skapar branches när det behövs.

---

## 7. Tidsplan

| Vecka | Mål — vad ska vara klart? | Ansvarig |
|---|---|---|
| 1 | Unity + VR installerat, tutorial genomförd, planering godkänd | |
| 2 | - | |
| 3 | Första prototyp | |
| 4 | "polished" version | |

**Deadline för första spelbara version (prototyp):**
3/9

**Deadline för färdigt bygge:**
11/9
---

## 8. Assets

Vad bygger ni själva och vad hämtar ni? Ange alltid källa och licens.

| Asset | Egen eller hämtad? | Källa / licens |
|---|---|---|
| | | |
| | | |
| | | |

---

## 9. Risker

Vad kan gå fel och vad gör ni då?

| Risk | Plan B |
|---|---|
| *Kastet känns fel i VR* | *Testa Throw Velocity Scale tidigt, be någon utanför gruppen testa* |
| *Vi hinner inte med 10 rutor bowling* | *Börja med ett enda kast och bygg ut* |
| | |

---

## 10. Lärarens godkännande

- [ ] Planeringen är godkänd

**Datum:**  **Signatur:**

**Kommentarer från läraren:**
