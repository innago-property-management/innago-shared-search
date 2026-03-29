# Innago.Shared.Search #

Structured Search and Sorting

```c#
IQueryable<Student> students = context.Students.AsNoTracking();

StudentSearchCriteria searchCriteria = new()
{
    StudentId = new ValueSearchCriteria<int>
    {
        NotEqualTo = 2,
    },
};

var sortOrder0 = new StudentSortOrder
{
    StudentId = SortOrderDirection.Descending,
};

var sortOrder1 = new StudentSortOrder
{
    Name = SortOrderDirection.Ascending,
};

StudentSortOrder[] order = { sortOrder1, sortOrder0 };

IAsyncEnumerable<Student> result = students.Where(searchCriteria).ApplySort(order).AsAsyncEnumerable();
```

The ultimate goal is to pass the criteria in via JSON through a REST API Endpoint called by a browser client.

```javascript
const searchCriteria = { StudentId: { GreaterThan: 3 } };
const searchOrder = [{ Name: "ascending" }, { Id: "descending" }];
```

```c#
var searchCriteria = JsonSerializer.Deserialize<StudentSearchCriteria>(jsonSearchCriteria)!;

var sortOrder = JsonSerializer.Deserialize<IEnumerable<StudentSortOrder>>(jsonSortOrder)!;

IQueryable<Student> students = context.Students.AsNoTracking();

IQueryable<Student> query = students.Where(searchCriteria).ApplySort(sortOrder);
```
