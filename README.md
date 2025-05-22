# [ServUO]

[![Build Status](https://travis-ci.com/ServUO/ServUO.svg?branch=master)](https://travis-ci.com/ServUO/ServUO)
[![GitHub issues](https://img.shields.io/github/issues/servuo/servuo.svg)](https://github.com/ServUO/ServUO/issues)
[![GitHub release](https://img.shields.io/github/release/servuo/servuo.svg)](https://github.com/ServUO/ServUO/releases)
[![GitHub repo size](https://img.shields.io/github/repo-size/servuo/servuo.svg)](https://github.com/ServUO/ServUO/)
[![Discord](https://img.shields.io/discord/110970849628000256.svg)](https://discord.gg/0cQjvnFUN26nRt7y)
[![GitHub contributors](https://img.shields.io/github/contributors/servuo/servuo.svg)](https://github.com/ServUO/ServUO/graphs/contributors)
[![GitHub](https://img.shields.io/github/license/servuo/servuo.svg?color=a)](https://github.com/ServUO/ServUO/blob/master/LICENSE)


ServUO is a community driven Ultima Online Server Emulator written in C#.


### Website

[ServUO]


#### Windows

Run `Compile.WIN - Debug.bat` for development, attaching a debugger and/or extended output.

Run `Compile.WIN - Release.bat` for production environment (-debug is still a supported parameter for script debugging).

After this you can run the server by executing `ServUO.exe`.


#### OSX
```
brew install mono
make
```


#### Ubuntu
```
apt-get install mono-complete
make
```


### Summary

1. Starting with the `/Config` directory, find and edit `Server.cfg` to set up the essentials.
2. Go through the remaining `*.cfg` files to ensure they suit your needs.
3. For Windows, run `Compile.WIN - Debug.bat` to produce `ServUO.exe`, Linux users may run `Makefile`.
4. Run `ServUO.exe` to make sure everything boots up, if everything went well, you should see your IP adress being listened on the port you specified.
5. Load up UO and login! - If you require instructions on setting up your particular client, visit the Discord and ask!



   [ServUO]: <https://www.servuo.com>


# Custom Changes

- Siege Ruleset
- Disable Siege ROT
- Sacred Journey & Recall re-enabled & Cast Delay multiplied by 3
- Keep equipped items on death (except cursed)
- NPCs train skills upto 100: All Guildmasters, Animal Trainer, Necromancer, Keeper of Chivalry, Ninja, Samurai, Aneen(Spellweaving), Ansikart(Imbuing), Agralem(Throwing), Mystic
- Add selections for starting city (Britain, Yew, Minoc, Moonglow, Trinsic, Jhelom, Skara Brae)
- Pet Bonding Delay changed from 7 days to 0 days
- A single kill makes you Red
- Use gold as soverigns (1000x multiplier)
- Enable Customizable Keep & Castle, Fix Keep/Castle swap lists, Adjust Keep/Castle/Customizable House pricing
- Added Cleanup Barrel and Officer to Tokuno and Luna Bank 

## WIP Changes

- Fix missing NPC spawn locations (Ter Mur): Royal City Bard
- Remove house vendor upkeep
- Investigate lag spike

## Setup compilation

- Run `apt install zlib1g-dev`
- Place a copy of client files adjacent to this repo in a folder named 'UOClassic'

## Setup Service

```
cp /home/UOGhost/uoghostd.service /etc/systemd/system/
systemctl daemon-reload
systemctl enable uoghostd.service
systemctl start uoghostd.service
journalctl -u uoghostd.service -f
```

## Setup World

In game as owner:

```
[createworld
[xmlload Spawns
[GenMiniChamp
[save
```
