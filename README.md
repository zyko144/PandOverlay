# PandOverlay

Overlay Rocket League pour Windows 10/11 64 bits : victoires, défaites, série et historique mensuel.

## Installer

[Télécharger PandOverlay Setup](https://github.com/zyko144/PandOverlay/releases/latest/download/PandOverlay-Setup.exe), ouvrir le fichier puis cliquer sur **Installer**. Le mini-guide apparaît une seule fois. L’installation se fait pour le compte Windows actuel, sans droits administrateur.

- Démarrage avec Rocket League activé par défaut, désactivable dans les réglages et les conseils.
- Un clic sur l’icône près de l’horloge ouvre l’application.
- **Alt + glisser** déplace l’overlay ou le logo. Le petit coin règle la taille ; la croix masque l’élément.
- Utiliser Rocket League en **fenêtré sans bordure**. L’overlay apparaît uniquement lorsque le jeu est au premier plan.

## Historique

L’onglet **Historique** permet de parcourir les mois et de filtrer par mode. Il affiche le bilan victoires/défaites, le taux de victoire et les détails disponibles : score, équipes, noms, points, buts, passes, arrêts et tirs.

Les compteurs du jour se remettent à zéro à minuit, heure de Paris. **Les archives restent conservées.** En freeplay, l’overlay affiche les compteurs du dernier mode joué.

Si le résultat n’a pas été reçu, la partie est marquée **Non confirmé**, sans modifier les victoires/défaites. Les détails incomplets sont signalés. Les anciennes parties qui n’ont pas été archivées ne peuvent pas être reconstituées.

## Mises à jour

Après cette installation, PandOverlay recherche les nouvelles versions sur les releases de ce dépôt. Le fichier est vérifié par signature et empreinte SHA-256, puis installé automatiquement hors partie. Les statistiques, les réglages et l’historique sont conservés. Aucune nouvelle exécution du setup n’est nécessaire pour les prochaines versions compatibles.

L’icône près de l’horloge propose également **Mises à jour** pour vérifier manuellement.

## Données et limites

Les données de jeu viennent de l’[API Stats locale de Rocket League](https://www.rocketleague.com/developer/stats-api). Quitter trop tôt peut empêcher la réception du résultat. L’identification de l’équipe utilise le compte Steam local ou, à défaut, le nom du joueur connecté ; un résultat ambigu n’est pas deviné à partir de la caméra.

Le rang est choisi manuellement. Cette version ne fournit pas le vrai MMR ni les promotions automatiques. BakkesMod et Overwolf ne sont pas nécessaires.

Les archives et les réglages restent dans `%LOCALAPPDATA%\PandOverlay`. Ils ne sont pas envoyés sur GitHub. Seule la recherche de mise à jour nécessite une connexion à GitHub.

La désinstallation depuis les applications Windows conserve les statistiques et les archives.
