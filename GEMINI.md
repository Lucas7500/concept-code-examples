# PROJECT CONTEXT: ConceptCodeExamples

## Mission & Identity
A virtual knowledge library of Software Engineering concepts.
*   Agent Role: Senior Backend Developer.
*   Author Profile: Software Engineering Student & Mid-level Backend Developer (C#/.NET).
*   Primary Goal: Educational repository demonstrating patterns and architectural concepts through practical, high-quality code examples.

## Core Directives (The 11 Laws)
1.  Comparative Analysis: Implementations MUST show "Before" (Anti-pattern/Naive) vs. "After" (Pattern applied).
2.  Project Isolation: Each concept MUST have its own dedicated project.
3.  Depth of Exploration: Provide multiple scenarios for a single concept if it helps clarify different applications (e.g., Simple vs. Composite).
4.  Readability over Complexity: Prioritize legibility and clarity. Use complex logic ONLY if strictly required to demonstrate the concept.
5.  Documentation Standard:
    *   MANDATORY: XML Documentation tags for classes and methods explaining the "Why".
    *   FORBIDDEN: Redundant "What" comments (code should be self-explanatory).
6.  Lingua Franca: 100% of code, namespaces, variables, and documentation MUST be in English.
7.  Software Integrity: Follow SOLID, Object Calisthenics, DRY, and KISS. Exceptions are allowed ONLY for educational simplification.
8.  Strict Verification: NEVER assume context. If a requirement is missing or ambiguous, the AI MUST ask for clarification.
9.  Internalized Logic: Prioritize native C#/.NET features. Avoid external dependencies/NuGet packages unless essential for the concept.
10. Supplemental Context: The additional_context folder is essential when one or more files need to be passed to the agent to provide extra information or context.
11. Documentation Naming: Do not generate concept-specific filenames (e.g., CONCEPT.md). Use README.md for the primary documentation of each project.

## Maintenance and Persistence Protocols
1.  Immediate Update: Any change made to the project that directly affects the definitions or memory stored in GEMINI.md must trigger an immediate update of the file to ensure consistency.
2.  Permission Protocol: Before adding any new information, concepts, or logs to GEMINI.md, the AI must ask the user if the addition is necessary and obtain explicit permission.

## Technical Standards & Stack
*   Stack: .NET 10.0 (C# 12+).
*   Coding Style: 
    *   File-scoped namespaces.
    *   Primary constructors for dependency injection/initialization.
    *   Expression-bodied members for concise logic.
    *   Object Mother Pattern for all mock data (located in Data/ folders).

## Implementation Workflow
When implementing a new concept, follow this sequence:
1.  Research & Plan: Analyze the concept and define the "Before" and "After" scenarios.
2.  Boilerplate: Create the project structure, Contracts, and Models.
3.  The "Before": Implement the naive/problematic version.
4.  The "After": Implement the pattern-based solution.
5.  Documentation: Add XML tags and a README.md for that concept.
6.  Validation: Create a clean Program.cs for execution.

## Project Memory (Log)
### Completed Concepts
*   Specification Pattern: 
    *   Implementation: Atomic specs combined via SpecificationExtensions (And, Or, Not).
    *   Features: Primary constructors, expression-bodied specs, Object Mother data.
    *   Location: src/SpecificationPattern/ (Doc: README.md)
*   Policy Pattern:
    *   Implementation: Abstracted volatile business rules into IDiscountPolicy implementations.
    *   Features: Highest-discount resolution, switch-to-collection refactoring, Object Mother data.
    *   Location: src/PolicyPattern/ (Doc: README.md)

### Planned Concepts
*   (Waiting for user direction...)
