# Unity Interaction Practice — README

## 🔹 Project Overview

This mini Unity project was designed to practice **basic object interaction** and **input handling** using C#. It focuses on controlling visibility, oscillation, and motion of 3D GameObjects through keyboard inputs.

---

## 🔹 Tasks Summary

### 1. **Oscillating Motion (Heartbeat Simulation)**

**Script:** `PulseBeat.cs`

* Demonstrates object scaling using a **Fourier approximation** of a square wave.
* Simulates a heart beating effect.
* Uses `Mathf.Sin()` with multiple harmonics to achieve a pulsing rhythm.

```csharp
float beat = (float)(Mathf.Sin(2 * pi * time) + 0.3f * Mathf.Sin(4f * pi * time) + 0.2f * Mathf.Sin(6f * pi * time));
beat = Mathf.Max(0, beat);
transform.localScale = Vector3.one * (1f + 1.3f * beat);
```

---

### 2. **Player Visibility Toggle**

**Script:** `PersonScript.cs`

* Pressing the **Spacebar** toggles the player object on/off.
* Uses the **new Input System** (`InputAction`) for clean input binding.
* Demonstrates lambda usage in event binding.

```csharp
hidePlayer = new InputAction(type: InputActionType.Button, binding: "Keyboard/space");
hidePlayer.Enable();
hidePlayer.performed += ctx => ToggleVisibility();
```

> **Note:** The script toggles visibility by setting `gameObject.SetActive()` and controlling all child renderers.

---

### 3. **Rotation Visualization**

**Goal:** Make rotation visible.

* A **small marker/dot** (using a primitive sphere or texture) was attached to the main sphere.
* Allows clear visual feedback when rotating the main object.

> Tip: Use `transform.Rotate(Vector3.up)` for Y-axis rotation in 3D.

---

### 4. **Lighting and Shadows Test**

**Goal:** Understand light and rendering in Unity.

* Added a **Directional Light (Sunlight)** to cast realistic shadows.
* Configured the **Mesh Renderer**:

  * `Cast Shadows`: **On**
  * `Static Shadow Caster`: **True**
* Verified that lighting works only in **3D templates**.

> 2D templates do not support 3D lighting or mesh-based shadows.

---

## 💡 Key Concepts Practiced

* Difference between **Sprite Renderer** (2D) and **Mesh Renderer** (3D).
* How to use **InputAction** for keyboard interaction.
* Understanding **axes** (`Vector3.up`, `Vector3.forward`, `Vector3.right`).
* Importance of lighting, materials, and shadows in object visibility.

---

## 🛠️ Technologies Used

* Unity 2022.3+ (3D Template)
* C# Scripts
* Universal Render Pipeline (URP)
* New Input System

---

## 📝 Summary

This exercise introduced fundamental Unity mechanics:

* Movement through sinusoidal functions
* Input handling with `InputAction`
* Object visibility management
* Shadow/light configuration

> Ideal for beginners to gain intuition on how scripting and Unity components interact in real-time 3D scenes.
