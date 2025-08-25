# 🏗️ Clean Architecture & SOLID Principles Study Repository

Repositório dedicado ao estudo dos princípios SOLID e Clean Architecture com .NET.

## 📚 Princípios em Estudo

- [x] **SRP** - Single Responsibility Principle ✅
- [ ] **OCP** - Open/Closed Principle
- [ ] **LSP** - Liskov Substitution Principle  
- [ ] **ISP** - Interface Segregation Principle
- [ ] **DIP** - Dependency Inversion Principle

## 🎯 SRP - Single Responsibility Principle

### ❌ `antes/` - Violação do SRP
- Classe `UsuarioService` com múltiplas responsabilidades
- Acoplamento alto e difícil manutenção

### ✅ `depois/` - Implementação Correta
- `UsuarioServices`: Apenas orquestração
- `UsuarioValidator`: Apenas validação  
- `UsuarioRepository`: Apenas persistência
- `Usuario`: Apenas modelo de dados
