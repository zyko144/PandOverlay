# PandOverlay

Overlay Rocket League pour Windows 10/11 64 bits : victoires, défaites, série et historique mensuel.

## Installer

[Télécharger PandOverlay Setup](https://github.com/zyko144/PandOverlay/releases/latest/download/PandOverlay-Setup.exe), ouvrir le fichier puis cliquer sur **Installer**. Les cinq astuces apparaissent directement au premier lancement, puis les réglages s’ouvrent. Le menu **Conseils** permet de revoir le guide. L’installation se fait pour le compte Windows actuel, sans droits administrateur.

- Démarrage avec Rocket League activé par défaut, désactivable dans les réglages et les conseils.
- Un clic sur l’icône près de l’horloge ouvre l’application.
- **Alt + glisser** déplace l’overlay. Le petit coin règle la taille ; la croix masque l’élément.
- **Alt + clic sur le petit +** de WINS ou LOSS ajoute un résultat au mode affiché. **Corriger les stats** permet aussi d’en retirer et de choisir un autre mode. Les compteurs ne deviennent jamais négatifs.
- Utiliser Rocket League en **fenêtré sans bordure**. L’overlay apparaît uniquement lorsque le jeu est au premier plan.

## Interface

Les pages **Overlay**, **Historique**, **Paramètres** et **Conseils** partagent une interface sombre bleutée avec barre latérale. Les aperçus utilisent les statistiques actuelles. L’historique affiche la liste des parties à gauche et leurs détails à droite.

## Historique

L’onglet **Historique** permet de parcourir les mois et de filtrer par mode. Il affiche le bilan victoires/défaites, le taux de victoire et les détails disponibles : score, équipes, noms, points, buts, passes, arrêts et tirs.

Les compteurs du jour se remettent à zéro à minuit, heure de Paris. **Les archives restent conservées.** En freeplay, l’overlay affiche les compteurs du dernier mode joué.

Les détails d’une partie permettent de corriger son résultat en **Victoire**, **Défaite** ou **Non confirmé**. Les changements manuels sont indiqués dans l’historique. Une correction d’une ancienne journée ne modifie pas les compteurs d’aujourd’hui. Retirer un résultat le garde visible, hors bilan.

Si un ajout correspond à une partie non confirmée du jour, cette partie est corrigée au lieu d’être dupliquée. Un résultat serveur reçu ensuite ne la comptera pas une seconde fois.

Si le résultat n’a pas été reçu, la partie est marquée **Non confirmé**, sans modifier les victoires/défaites. Les détails incomplets sont signalés. Les anciennes parties qui n’ont pas été archivées ne peuvent pas être reconstituées.

## Mises à jour

Après cette installation, PandOverlay recherche les nouvelles versions sur les releases de ce dépôt. Le fichier est vérifié par signature et empreinte SHA-256, puis installé automatiquement hors partie. Les statistiques, les réglages et l’historique sont conservés. Aucune nouvelle exécution du setup n’est nécessaire pour les prochaines versions compatibles.

L’icône près de l’horloge propose également **Mises à jour** pour vérifier manuellement.

## Données et limites

Les données de jeu viennent de l’[API Stats locale de Rocket League](https://www.rocketleague.com/developer/stats-api). Quitter trop tôt peut empêcher la réception du résultat. L’identification de l’équipe utilise le compte Steam local ou, à défaut, le nom du joueur connecté ; un résultat ambigu n’est pas deviné à partir de la caméra.

L’interface ne comporte aucune rubrique ni aucun logo de rang. Le MMR n’est pas affiché. BakkesMod et Overwolf ne sont pas nécessaires.

Les archives et les réglages restent dans `%LOCALAPPDATA%\PandOverlay`. Ils ne sont pas envoyés sur GitHub. Seule la recherche de mise à jour nécessite une connexion à GitHub.

La désinstallation depuis les applications Windows conserve les statistiques et les archives.
