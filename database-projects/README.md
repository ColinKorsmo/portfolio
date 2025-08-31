# Database Projects

This folder contains projects showcasing database design, Entity Framework Core implementation, and data modeling skills with SQLite integration.

## Projects Overview

### Entity Framework Core Applications
**Source:** FALL24/homework-4, homework-5, homework-6, homework-7, lab-8, lab-10  
**Technologies:** Entity Framework Core, SQLite, C#, Data Modeling, Migrations  
**Description:** Collection of database-driven applications demonstrating progressive mastery of Entity Framework Core concepts and database design principles.

**Key Database Features:**
- **Code-First Migrations:** Automated database schema generation
- **Data Models:** Complex entity relationships and constraints
- **Seed Data:** Automated test data population
- **CRUD Operations:** Complete data manipulation capabilities
- **Query Optimization:** Efficient data retrieval patterns

### Product Catalog System
**Source:** FALL24/homework-4  
**Technologies:** Entity Framework Core, SQLite, Product Management  
**Description:** Database system for managing product catalogs with full CRUD operations and data validation.

**Database Schema:**
- Product entities with properties and relationships
- Category management and classification
- Inventory tracking and management
- Price history and updates

### Comprehensive Catalog Application
**Source:** FALL24/homework-5  
**Technologies:** Entity Framework Core, SQLite, Advanced Relationships  
**Description:** Advanced catalog system with complex data relationships and business logic implementation.

**Advanced Features:**
- Multi-table relationships and foreign keys
- Data validation and business rules
- Transaction management
- Performance optimization techniques

### Laboratory Database Projects
**Source:** FALL24/lab-8, lab-10  
**Technologies:** Entity Framework Core, SQLite, Database Design  
**Description:** Hands-on database exercises focusing on practical implementation of database concepts and Entity Framework features.

## Skills Demonstrated

- **Database Design:** Schema design, normalization, relationships
- **Entity Framework Core:** Code-first approach, migrations, DbContext
- **Data Modeling:** Entity relationships, constraints, validation
- **SQL Knowledge:** Query optimization, database operations
- **Data Management:** CRUD operations, seed data, data integrity
- **Performance:** Query optimization, efficient data access patterns

## Technical Highlights

### Database Technologies
- **SQLite:** Lightweight, embedded database solution
- **Entity Framework Core:** Modern ORM with advanced features
- **Migrations:** Version control for database schema changes
- **Seed Data:** Automated test data generation and population

### Data Architecture Patterns
- **Repository Pattern:** Clean separation of data access logic
- **Unit of Work:** Transaction management and data consistency
- **Domain Models:** Business logic encapsulation
- **Data Transfer Objects:** Efficient data transportation

## Database Schema Examples

```csharp
// Example Entity Model
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
```

## How to Run Database Projects

```bash
cd [project-folder]
dotnet restore
dotnet ef database update  # Apply migrations
dotnet run
```

## Learning Outcomes

These projects demonstrate comprehensive understanding of modern database development practices, from basic CRUD operations to complex data relationships and performance optimization. The progression shows mastery of Entity Framework Core and database design principles essential for enterprise application development.
