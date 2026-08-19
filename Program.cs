IStudyRepository repository = new InMemoryStudyRepository();

StudyTopic topic = new()
{
    Name = "Big O",
    Description = "Understanding algorithmic complexity",
    Difficulty = 2
};

repository.Save(topic);

StudyTopic? result = repository.GetByName("Big O");

Console.WriteLine(result?.GetSummary());