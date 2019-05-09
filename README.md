# Administration-Lorillard

## Mise en place de la base de données

 1. Pour la suite il vous faudra une base de données. Si vous n'avez pas de serveur à disposition vous pouvez utiliser [WampServer](http://www.wampserver.com/).
 Vous pouvez accéder à votre base de données [ici](http://localhost/phpmyadmin/) à l'aide du SGBD **PhpMyAdmin** après avoir lancer wamp et que l'icone soit verte dans votre barre de tâches.

 Il vous faudra ensuite importer la base de données que vous trouverez [ici](https://drive.google.com/uc?export=download&id=1E7CyrabDDIEhkyJOuavRYhdxqFt0XcJ0)

 2. Pour ce faire aller sur [votre interface](http://localhost/phpmyadmin/).Pour vous connecter pour la première fois vous devez vous connecter avec les identifiants Admin. L'identifiant est **root** et aucun mot de passe. Maintenant créez une nouvelle base de données en cliquant sur le bouton **Nouvelle Base de données** en haut du menu droit.
 nommer la base donnée "**administrationlorillard**" puis valider.
 
 3. Vous devez créer un nouvelle utilisateurs ayant les privilèges de **SELECT**, **INSERT**, **DELETE**, **UPDATE**, **FILE**. Il doit avoir comme identifiant **admin** et comme mot de passe **lorillard**.
 
 3. cliquer sur votre base données pour la sélectionner. Ensuite cliquer sur le bouton **Importer** dans le menu Horizontal en haut de l'écran.
 cliquer sur le bouton **Choose File** et sélectionner la base de données que je vous ai fourni. Cliquer sur le bouton **Executer** en bas de la page.


## Installation

Pour Installer l'application un installateur existe. Vous le trouverez [ici](installateur à refaire avec stat et à upload gdrive avec la bdd). Il vous suffit de suivre les étapes d'installation.


## Un problème ?

Si vous ne voyez aucune données dans la partie inférieur de l'application, cela signifie que l'application n'as pas réussi à se connecter à la base données. Vérifier que vous avez correctement suivie les indications de la **mis en place de la base de données**, en particulier vérifier d'avoir mis **exactement** les noms en gras.
