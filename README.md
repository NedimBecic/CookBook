# Verification and validation of software course project - Cookbook Application

This repository contains the project developed for the **Verification and Validation of Software** elective course at the Faculty of Electrical Engineering, University of Sarajevo.

This was a team-based project where our group (Group 4) was assigned the task of developing and validating a **Cookbook (Knjiga recepata)** application. The project spanned multiple phases, covering various essential topics in software verification and validation.

## Project Overview

The project was divided into several parts, each focusing on different aspects of ensuring software quality:

1.  **Part I: Application Development & Specification**
    *   Developed a moderately complex console-based **Cookbook application** using the .NET framework.
    *   Focused on core functionalities, implementing custom algorithms (e.g., for searching/sorting recipes), proper exception handling, and object-oriented design principles (interfaces, inheritance).
    *   Created a software specification document, including a class diagram.
    *   Utilized Git for version control, adhering to branching and pull request workflows.

2.  **Part II: Code Quality Assurance & Internal Testing**
    *   **Code Inspection:** Performed peer code reviews of another team's project using Azure DevOps, including creating pull requests, adding comments, and tracking issues. Conducted a Pareto analysis of identified defects.
    *   **Unit Testing:** Wrote comprehensive unit tests for our Cookbook application's codebase, aiming for high code coverage (>= 90%). Applied data-driven testing techniques and utilized mock objects for dependencies.
    *   **Test-Driven Development (TDD):** Specified and implemented new features for the Cookbook application following the TDD methodology, writing tests before implementation.

3.  **Part III: External Application Testing (Group Task)**
    *   **Note:** This part involved testing a *publicly available external web application*, not our Cookbook application.
    *   **Functional Testing:** Designed and documented black-box test cases using Azure DevOps to cover the application's functionalities and identify bugs.
    *   **Test Automation:** Automated the previously designed test cases using Selenium IDE and subsequently developed a more robust automation framework using NUnit and Selenium WebDriver, implementing the Page Object Model (POM) and Singleton design patterns.
    *   **API Testing:** Used Postman to create and execute API tests against the external application's endpoints, including multiple validations per test.
    *   **Load Testing:** Performed load testing on the external application using a chosen tool (e.g., Loadster, Pingdom) and analyzed the performance results.

## Key Concepts & Technologies Covered

Throughout this project, our team gained practical experience with:

*   Git & Azure DevOps (Version Control, Pull Requests, Issue Tracking)
*   Code Inspection & Peer Review
*   Pareto Analysis
*   Unit Testing (NUnit)
*   Code Coverage Analysis
*   Data-Driven Testing
*   Mocking/Test Doubles
*   Test-Driven Development (TDD)
*   Functional Black-Box Testing Techniques
*   Test Case Design & Management
*   Test Automation (Selenium IDE, Selenium WebDriver)
*   Page Object Model (POM) Design Pattern
*   API Testing (Postman)
*   Load Testing & Performance Analysis
*   Test Reporting
