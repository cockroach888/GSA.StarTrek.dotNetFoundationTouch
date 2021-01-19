namespace GenericHost4Lib01.Sample2Interface
{
    /// <summary>
    /// 奥特曼接口
    /// </summary>
    public interface IUltraman : IUniqueOfMultipleImplementations
    {
        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 文本
        /// </summary>
        string Text { get; }
    }
}
