## Objectif

Difficile de trouver un moment libre dans l'agenda de tous vos collègues pour organiser vos réunions d'équipe !
Vous décidez de leur communiquer les créneaux où ils sont indisponibles. En utilisant ces données, votre objectif est de
trouver un créneau de 60 mins consécutives qui conviendra à tout le monde pendant la semaine à venir.

## Données

*Entrée*

Ligne 1 : Un entier N compris entre 1 et 1000 représentants le nombre de créneau impossibles pour la réunion. Ligne 2 à
N+1 : Un créneau impossible au format jour hh:mm-hh:mm. Le jour est au format Iso : 1 = lundi, 2 = mardi, … Les minutes
de début et de fin sont incluses dans l’indisponibilité. Les horaires de travail sont du lundi au vendredi de 8 :00 à
17h59. Les créneaux impossibles sont inclus dans les horaires de travail.

*Sortie*

Une ligne au format jour hh:mm-hh:mm représentant l’horaire de la réunion choisie. Il doit être :

- Pendant les horaires de travail, sans les dépasser.
- D’une durée exactement de 60 mins.
- Les minutes de début et de fin sont incluses donc une réunion de 08:00 à 08:59 fait exactement 60 mins.
- N’est interdiction avec aucun créneau impossible d’un collègue.
- Il y a au moins une solution, le premier créneau est choisit lorsqu'il y en a plus d'une.

__Exemple__

Pour l’entrée :

```
5
1 08:45-12:59
3 11:09-11:28
5 09:26-09:56
5 16:15-16:34
3 08:40-10:12
```

Une solution possible est :
1 13:00-13:59 Il y en a bien d’autres, notamment le jour 2. La premiere est retenue
