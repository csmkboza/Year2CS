IStudyRepository repository = new InMemoryStudyRepository();

StudyService service = new(repository);

StudyTopic bigO = new()
{
    Id = Guid.NewGuid(),
    Name = "Big O",
    Description = "Understanding algorithmic complexity",
    Difficulty = 2
};

service.AddTopic(bigO);

StudyTopic? found = service.FindTopic(bigO.Id);

Console.WriteLine(found?.GetSummary());