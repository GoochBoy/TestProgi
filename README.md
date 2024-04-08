# TestProgi
Test Progi de Jean Michel Bissonnette

# Outil de calcul d’encan
 
## Objectif
 
L'objectif de l'exercice suivant est d'évaluer la capacité d'un programmeur à développer un produit minimum viable. Notez que cet exercice ne simule pas une situation de travail réelle. L'objectif est de développer une application simple en utilisant les bonnes pratiques de programmation.
 
### Important:
- Vous devez développer une application web, et non une application desktop
- Étant donné que nous recherchons un développeur full-stack, vous devez fournir un backend et un frontend communiquant ensemble
- Le langage de programmation backend à utiliser est celui spécifié dans la description du poste.
- Le front-end (UI) doit être construit en utilisant un framework approprié (idéalement Vue.js, mais d'autres frameworks sont également acceptables)
 
 
## Critères d'évaluation
 
La solution finale sera évaluée en fonction des critères suivants :
- Clarté du code
- Algorithme et résultat des calculs
- Utilisation des principes de la programmation orientée objet
- Mise en œuvre de bonnes pratiques d'architecture logicielle (Clean Code, SOLID, KISS, DRY, YAGNI, etc.)
- Utilisation appropriée des frameworks, outils et bibliothèques liés au langage de programmation utilisé
 
## Description de la tâche
 
Développer une application qui permettra à un acheteur de calculer le prix total d'un véhicule (ordinaire ou de luxe) lors d'une vente aux enchères. Le logiciel doit prendre en compte plusieurs coûts dans le calcul. L'acheteur doit payer divers frais pour la transaction, qui sont tous calculés sur le montant du prix de base. Le montant total calculé est le montant de l'offre gagnante (prix de base du véhicule) plus les frais basés sur le prix et le type de véhicule. Les frais doivent être calculés de manière dynamique.
 
## Requis
 
Un champ permet de saisir le prix de base du véhicule.
Un champ permet de spécifier le type de véhicule (ordinaire ou de luxe).
La liste des frais et leur montant sont affichés.
Le coût total est automatiquement calculé et affiché chaque fois que le prix ou le type change.
 
## Coût fixes et variables
 
- Frais d'utilisation de base : 10% du prix du véhicule
    - Voiture ordinaire : minimum 10 $ et maximum 50 $
    - Voiture de luxe : minimum 25 $ et maximum 200$
- Frais spéciaux du vendeur :
    - Voiture ordinaire : 2% du prix du véhicule
    - Voiture de luxe : 4% du prix du véhicule
- Les frais supplémentaires d'association en fonction du prix du véhicule :
    - 5 \$ pour un montant compris entre 1 \$ et 500 \$
    - 10 \$ pour un montant supérieur à 500 \$ et inférieur ou égal à 1000 \$
    - 15 \$ pour un montant supérieur à 1000 \$ jusqu'à 3000 \$
    - 20 \$ pour un montant supérieur à 3 000 \$
- Des frais d'entreposage fixes de 100 \$
 
## Exemple de calcul
 
- Prix du véhicule (ordinaire) : 1 000 \$
- Frais de base : 50 \$ (10 %, min : 10 \$, max. 50 $)
- Frais spéciaux : 20 \$ (2 %)
- Frais d'association : 10 \$
- Frais d'entreposage : 100 \$
- Total: 1 180 \$ = 1 000\$ + 50\$ + 20\$ + 10\$ + 100\$
 
## Cas de test
 
| Prix du véhicule (\$) | Type de véhicule | De base |   Spéciaux | Association | Entreposage |  Total (\$) |
|                  ---: |       :----:     |    ---: |       ---: |        ---: |        ---: |        ---: |
|                398.00 |       Ordinaire  |   39.80 |      7.96  |        5.00 |      100.00 |      550.76 |
|                501.00 |       Ordinaire  |   50.00 |     10.02  |       10.00 |      100.00 |      671.02 |
|                57.00  |       Ordinaire  |   10.00 |      1.14  |        5.00 |      100.00 |      173.14 |
|              1 800.00 |       De luxe    |  180.00 |     72.00  |       15.00 |      100.00 |    2 167.00 |
|              1 100.00 |       Ordinaire  |   50.00 |     22.00  |       15.00 |      100.00 |    1 287.00 |
|          1 000 000.00 |       De luxe    |  200.00 | 40 000.00  |       20.00 |      100.00 |1 040 320.00 |

 