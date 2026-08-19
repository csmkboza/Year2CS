class InMemoryStudyRepository : IStudyRepository
{
    private readonly List<StudyTopic> topics = [];

    public void Save(StudyTopic topic)
    {
        topics.Add(topic);
    }

    public StudyTopic? GetByName(string name)
    {
        return topics.FirstOrDefault(t => t.Name == name);
    }
}