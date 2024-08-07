public abstract class EIrsaliye_EFatura : BaseDocument
{
	public abstract List<AlinanBelge> AlinanFaturalarListesi();
	public abstract void Indir();
	public abstract void Kabul();
	public abstract void Red();
	public abstract void GonderilenGuncelleByDate();
	public abstract void GonderilenGuncelleByList();
}