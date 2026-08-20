class InMemoryStudyRepository : IStudyRepository
{
    private readonly Dictionary<Guid, StudyTopic> topics = [];

    public void Save(StudyTopic topic)
    {
        topics[topic.Id] = topic;
    }

    public StudyTopic? GetById(Guid id)
    {
        return topics.GetValueOrDefault(id);
    }
}