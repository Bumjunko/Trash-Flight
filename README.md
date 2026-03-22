# Trash Flight

A 2D arcade shooter built with Unity where the player dodges falling trash-themed enemies, collects coins, upgrades weapons, and defeats a boss.

## Tech Stack

- Unity 6
- C#

## Gameplay

- Player horizontal movement (mouse tracking)
- Automatic shooting with multiple weapon levels
- Enemy waves across fixed lanes with increasing speed and stronger variants
- Boss spawn after the regular wave cycle
- Coin drops and coin counter UI
- Weapon upgrade every 30 coins
- Game over / clear panel with replay button
- Auto-scrolling background

## Controls

- Move the player with the mouse
- Shooting is automatic
- Click the replay button on the game over panel to restart the stage

## Project Structure

- `Assets/Scripts/Player.cs`: player movement, shooting, weapon upgrades
- `Assets/Scripts/EnemySpawner.cs`: lane-based wave spawning and boss spawn
- `Assets/Scripts/Enemy.cs`: enemy movement, damage handling, coin drops, boss clear trigger
- `Assets/Scripts/GameManager.cs`: coin UI, game over / clear flow, replay
- `Assets/Scripts/Coin.cs`: coin physics jump and cleanup

## Current State

The game loop is playable end-to-end: survive enemy waves, collect coins to upgrade weapons, and defeat the boss to clear the stage.
