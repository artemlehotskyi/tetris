<div align="center">

<img src="assets/banner.svg" alt="Tetris" width="100%">

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-68217A?style=for-the-badge&logoColor=white)
![Rider](https://img.shields.io/badge/Rider-000000?style=for-the-badge&logo=rider&logoColor=white)
![macOS](https://img.shields.io/badge/macOS-1A1030?style=for-the-badge&logo=apple&logoColor=white)
![Status](https://img.shields.io/badge/Status-In_Progress-8B5CF6?style=for-the-badge)

</div>

---

# tetris — a console Tetris in C#

A Tetris that runs in the terminal: a grid drawn with characters, pieces that fall, rotate
and lock, lines that clear. No game engine and no graphics library — just `Console` and
plain classes.

---

## 🎯 Learning goal

This is practice for my university OOP course, built alongside
[csharp-learning](https://github.com/artemlehotskyi/csharp-learning). The labs there are
small, isolated tasks; here the same ideas have to hold together in one program that keeps
growing.

I write all of the game code by hand. The order of the roadmap follows the course: a class
hierarchy only appears once the course has covered inheritance, and only where a piece
actually behaves differently — not as decoration.

---

## 🗺 Roadmap

| № | Step | What it is about | Status |
|---|---|---|---|
| 1 | Board | grid, bounds (`IsInside`), cell state (`IsEmpty` / `SetCell`), `Draw` | ✅ done |
| 2 | Tetromino | one class, shape passed as data through the constructor; `RotateLeft` / `RotateRight` / `Move`, `GetAbsoluteCells` for board coordinates | ✅ done |
| 3 | Collision | `CanPlace` check, `Lock` to settle a piece; move-then-revert checked by hand in `Program.cs` | ✅ done |
| 4 | Game loop | non-blocking input (`Console.KeyAvailable` / `ReadKey`), timing, rendering | ⏳ next |
| 5 | Polymorphism | subclasses only where behaviour differs: the O-piece doesn't rotate, the I-piece needs wall kicks | 🔒 after the course covers inheritance |

---

## ▶️ How to run

```bash
git clone https://github.com/artemlehotskyi/tetris.git && cd tetris
dotnet run --project Tetris
```

There's no playable game yet. For now `Program.cs` is a hand-written check of steps 1–3:
it places a T-piece, pushes it past the floor and back, locks it, draws the board, and
tests overlap and the left wall, printing `True` / `False` for each case.

Requires the .NET 10 SDK. Run it in a real terminal rather than the IDE's output pane once
the game loop lands — non-blocking key input needs an interactive console.

---

## 🛠 Stack

| | |
|---|---|
| Runtime | .NET 10.0 |
| IDE | JetBrains Rider |
| OS | macOS |
