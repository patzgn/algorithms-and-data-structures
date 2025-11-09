# Asymptotic Notation

**Asymptotic notation** describes how an algorithm’s performance (usually time or space) grows as input size **n → ∞**.  
It focuses on the **rate of growth**, ignoring constant factors and lower-order terms.

## Why it matters
- Compares algorithms independently of hardware or implementation.  
- Reveals scalability — how performance behaves with large inputs.  
- Abstracts away constants: `3n² + 10n + 7` → just `Θ(n²)`.

### Intuition
Think of it as **"how fast does it blow up?"** when n grows very large.  
It’s about trends, not exact numbers.


## Common Asymptotic Notations

### **1. Big O — Upper Bound**
Describes the **worst-case** growth rate.  

`T(n) = O(f(n))  ⇒  T(n) ≤ c · f(n)`

Means the algorithm grows *no faster than* `f(n)`.

**Example:**  
`3n² + 5n + 7 = O(n²)`

---

### **2. Big Omega (Ω) — Lower Bound**
Describes the **best-case** growth rate.  

`T(n) = Ω(f(n))  ⇒  T(n) ≥ c · f(n)`

Means the algorithm grows *at least as fast as* `f(n)`.

**Example:**  
`3n² + 5n + 7 = Ω(n²)`

---

### **3. Big Theta (Θ) — Tight Bound**
Describes the **exact asymptotic rate**.  

`T(n) = Θ(f(n))  ⇒  c₁·f(n) ≤ T(n) ≤ c₂·f(n)`

Means the algorithm grows *proportionally* to `f(n)`.

**Example:**  
`3n² + 5n + 7 = Θ(n²)`

---

### **4. Small o — Strictly Smaller**
Describes growth that is **asymptotically smaller** than `f(n)`.  

`T(n) = o(f(n))  ⇒  lim (n→∞) T(n)/f(n) = 0`

**Example:**  
`n = o(n²)`

---

### **5. Small Omega (ω) — Strictly Greater**
Describes growth that is **asymptotically larger** than `f(n)`.  

`T(n) = ω(f(n))  ⇒  lim (n→∞) T(n)/f(n) = ∞`

**Example:**  
`n² = ω(n)`
