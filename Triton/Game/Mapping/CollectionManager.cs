﻿namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionManager")]
    public class CollectionManager : MonoClass
    {
        public CollectionManager(IntPtr address) : this(address, "CollectionManager")
        {
        }

        public CollectionManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCardReward(CardRewardData cardReward, bool markAsNew)
        {
            object[] objArray1 = new object[] { cardReward, markAsNew };
            base.method_8("AddCardReward", objArray1);
        }

        public CollectibleCard AddCounts(NetCache.CardStack netStack, EntityDef entityDef)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { netStack, entityDef };
            return base.method_15<CollectibleCard>("AddCounts", enumArray1, objArray1);
        }

        public CollectibleCard AddCounts(EntityDef entityDef, string cardID, TAG_PREMIUM premium, DateTime insertDate, int count, int numSeen)
        {
            object[] objArray1 = new object[] { entityDef, cardID, premium, insertDate, count, numSeen };
            return base.method_15<CollectibleCard>("AddCounts", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public CollectionDeck AddDeck(NetCache.DeckHeader deckHeader)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { deckHeader };
            return base.method_15<CollectionDeck>("AddDeck", enumArray1, objArray1);
        }

        public CollectionDeck AddDeck(NetCache.DeckHeader deckHeader, bool updateNetCache)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { deckHeader, updateNetCache };
            return base.method_15<CollectionDeck>("AddDeck", enumArray1, objArray1);
        }

        public void AddPreconDeck(TAG_CLASS heroClass, long deckID)
        {
            object[] objArray1 = new object[] { heroClass, deckID };
            base.method_8("AddPreconDeck", objArray1);
        }

        public void AddPreconDeckFromNotice(NetCache.ProfileNoticePreconDeck preconDeckNotice)
        {
            object[] objArray1 = new object[] { preconDeckNotice };
            base.method_8("AddPreconDeckFromNotice", objArray1);
        }

        public string AutoGenerateDeckName(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return base.method_13("AutoGenerateDeckName", objArray1);
        }

        public void ClearTaggedDeck(DeckTag tag)
        {
            object[] objArray1 = new object[] { tag };
            base.method_8("ClearTaggedDeck", objArray1);
        }

        public void DoneEditing()
        {
            base.method_8("DoneEditing", Array.Empty<object>());
        }

        public int EntityDefSortComparison(EntityDef entityDef1, EntityDef entityDef2)
        {
            object[] objArray1 = new object[] { entityDef1, entityDef2 };
            return base.method_11<int>("EntityDefSortComparison", objArray1);
        }

        public void FireAllDeckContentsEvent()
        {
            base.method_8("FireAllDeckContentsEvent", Array.Empty<object>());
        }

        public void FireDeckContentsEvent(long id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("FireDeckContentsEvent", objArray1);
        }

        public static CollectionManager Get()
        {
            return MonoClass.smethod_15<CollectionManager>(TritonHs.MainAssemblyPath, "", "CollectionManager", "Get", Array.Empty<object>());
        }

        public List<CollectibleCard> GetAllCards()
        {
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GetAllCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public CollectionDeck GetBaseDeck(long id)
        {
            object[] objArray1 = new object[] { id };
            return base.method_14<CollectionDeck>("GetBaseDeck", objArray1);
        }

        public int GetBasicCardsIOwn(TAG_CLASS cardClass)
        {
            object[] objArray1 = new object[] { cardClass };
            return base.method_11<int>("GetBasicCardsIOwn", objArray1);
        }

        public TAG_PREMIUM GetBestCardPremium(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            return base.method_11<TAG_PREMIUM>("GetBestCardPremium", objArray1);
        }

        public List<CollectibleCard> GetBestHeroesIOwn(TAG_CLASS heroClass)
        {
            object[] objArray1 = new object[] { heroClass };
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GetBestHeroesIOwn", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public CollectibleCard GetCard(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_14<CollectibleCard>("GetCard", objArray1);
        }

        public int GetCardsToDisenchantCount()
        {
            return base.method_11<int>("GetCardsToDisenchantCount", Array.Empty<object>());
        }

        public int GetCardTypeSortOrder(EntityDef entityDef)
        {
            object[] objArray1 = new object[] { entityDef };
            return base.method_11<int>("GetCardTypeSortOrder", objArray1);
        }

        public CollectionDeck GetDeck(long id)
        {
            object[] objArray1 = new object[] { id };
            return base.method_14<CollectionDeck>("GetDeck", objArray1);
        }

        public DeckBuilder GetDeckBuilder()
        {
            return base.method_14<DeckBuilder>("GetDeckBuilder", Array.Empty<object>());
        }

        public List<CollectionDeck> GetDecks(DeckType deckType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { deckType };
            Class267<CollectionDeck> class2 = base.method_15<Class267<CollectionDeck>>("GetDecks", enumArray1, objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetDeckSize()
        {
            return base.method_11<int>("GetDeckSize", Array.Empty<object>());
        }

        public List<CollectionDeck> GetDecksWithClass(TAG_CLASS classType, DeckType deckType)
        {
            object[] objArray1 = new object[] { classType, deckType };
            Class267<CollectionDeck> class2 = base.method_14<Class267<CollectionDeck>>("GetDecksWithClass", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<TAG_CARD_SET> GetDisplayableCardSets()
        {
            Class266<TAG_CARD_SET> class2 = base.method_14<Class266<TAG_CARD_SET>>("GetDisplayableCardSets", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public CollectionDeck GetEditedDeck()
        {
            return base.method_14<CollectionDeck>("GetEditedDeck", Array.Empty<object>());
        }

        public NetCache.CardDefinition GetFavoriteHero(TAG_CLASS heroClass)
        {
            object[] objArray1 = new object[] { heroClass };
            return base.method_14<NetCache.CardDefinition>("GetFavoriteHero", objArray1);
        }

        public List<CollectibleCard> GetHeroesIOwn(TAG_CLASS heroClass)
        {
            object[] objArray1 = new object[] { heroClass };
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GetHeroesIOwn", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<CollectibleCard> GetMassDisenchantCards()
        {
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GetMassDisenchantCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetNumCopiesInCollection(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<int>("GetNumCopiesInCollection", objArray1);
        }

        public List<CollectibleCard> GetOwnedCards()
        {
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GetOwnedCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public PreconDeck GetPreconDeck(TAG_CLASS heroClass)
        {
            object[] objArray1 = new object[] { heroClass };
            return base.method_14<PreconDeck>("GetPreconDeck", objArray1);
        }

        public CollectionDeck GetTaggedDeck(DeckTag tag)
        {
            object[] objArray1 = new object[] { tag };
            return base.method_14<CollectionDeck>("GetTaggedDeck", objArray1);
        }

        public List<TemplateDeck> GetTemplateDecks(TAG_CLASS classType)
        {
            object[] objArray1 = new object[] { classType };
            Class267<TemplateDeck> class2 = base.method_14<Class267<TemplateDeck>>("GetTemplateDecks", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public string GetVanillaHeroCardID(EntityDef HeroSkinEntityDef)
        {
            object[] objArray1 = new object[] { HeroSkinEntityDef };
            return base.method_13("GetVanillaHeroCardID", objArray1);
        }

        public string GetVanillaHeroCardIDFromClass(TAG_CLASS heroClass)
        {
            object[] objArray1 = new object[] { heroClass };
            return base.method_13("GetVanillaHeroCardIDFromClass", objArray1);
        }

        public bool HasVisitedCollection()
        {
            return base.method_11<bool>("HasVisitedCollection", Array.Empty<object>());
        }

        public static void Init()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "CollectionManager", "Init");
        }

        public void InitImpl()
        {
            base.method_8("InitImpl", Array.Empty<object>());
        }

        public void InsertNewCollectionCard(string cardID, TAG_PREMIUM premium, DateTime insertDate, int count, bool seenBefore)
        {
            object[] objArray1 = new object[] { cardID, premium, insertDate, count, seenBefore };
            base.method_8("InsertNewCollectionCard", objArray1);
        }

        public bool IsCardInCollection(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<bool>("IsCardInCollection", objArray1);
        }

        public bool IsDeckNameTaken(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_11<bool>("IsDeckNameTaken", objArray1);
        }

        public bool IsFullyLoaded()
        {
            return base.method_11<bool>("IsFullyLoaded", Array.Empty<object>());
        }

        public bool IsInEditMode()
        {
            return base.method_11<bool>("IsInEditMode", Array.Empty<object>());
        }

        public bool IsWaitingForBoxTransition()
        {
            return base.method_11<bool>("IsWaitingForBoxTransition", Array.Empty<object>());
        }

        public void LoadTemplateDecks()
        {
            base.method_8("LoadTemplateDecks", Array.Empty<object>());
        }

        public void MarkAllInstancesAsSeen(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            base.method_8("MarkAllInstancesAsSeen", objArray1);
        }

        public void NetCache_OnDecksReceived()
        {
            base.method_8("NetCache_OnDecksReceived", Array.Empty<object>());
        }

        public void NetCache_OnFavoriteHeroesReceived()
        {
            base.method_8("NetCache_OnFavoriteHeroesReceived", Array.Empty<object>());
        }

        public void NotifyNetCacheOfNewCards(NetCache.CardDefinition cardDef, long insertDate, int count, bool seenBefore)
        {
            object[] objArray1 = new object[] { cardDef, insertDate, count, seenBefore };
            base.method_8("NotifyNetCacheOfNewCards", objArray1);
        }

        public void NotifyNetCacheOfRemovedCards(NetCache.CardDefinition cardDef, int count)
        {
            object[] objArray1 = new object[] { cardDef, count };
            base.method_8("NotifyNetCacheOfRemovedCards", objArray1);
        }

        public void NotifyOfBoxTransitionStart()
        {
            base.method_8("NotifyOfBoxTransitionStart", Array.Empty<object>());
        }

        public int NumCardsOwnedInSet(TAG_CARD_SET cardSet)
        {
            object[] objArray1 = new object[] { cardSet };
            return base.method_11<int>("NumCardsOwnedInSet", objArray1);
        }

        public void OnActiveAchievesUpdated(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnActiveAchievesUpdated", objArray1);
        }

        public void OnBoxTransitionFinished(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnBoxTransitionFinished", objArray1);
        }

        public void OnCardRewardOpened(string cardID, TAG_PREMIUM premium, int count)
        {
            object[] objArray1 = new object[] { cardID, premium, count };
            base.method_8("OnCardRewardOpened", objArray1);
        }

        public void OnCardSale()
        {
            base.method_8("OnCardSale", Array.Empty<object>());
        }

        public void OnCollectionChanged()
        {
            base.method_8("OnCollectionChanged", Array.Empty<object>());
        }

        public void OnDBAction()
        {
            base.method_8("OnDBAction", Array.Empty<object>());
        }

        public void OnDeck()
        {
            base.method_8("OnDeck", Array.Empty<object>());
        }

        public void OnDeckCreated()
        {
            base.method_8("OnDeckCreated", Array.Empty<object>());
        }

        public void OnDeckDeleted()
        {
            base.method_8("OnDeckDeleted", Array.Empty<object>());
        }

        public void OnDeckRenamed()
        {
            base.method_8("OnDeckRenamed", Array.Empty<object>());
        }

        public void OnDefaultCardBackSet()
        {
            base.method_8("OnDefaultCardBackSet", Array.Empty<object>());
        }

        public void OnMassDisenchantResponse()
        {
            base.method_8("OnMassDisenchantResponse", Array.Empty<object>());
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnSetFavoriteHeroResponse()
        {
            base.method_8("OnSetFavoriteHeroResponse", Array.Empty<object>());
        }

        public CollectibleCard RegisterCard(EntityDef entityDef, string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { entityDef, cardID, premium };
            return base.method_14<CollectibleCard>("RegisterCard", objArray1);
        }

        public void RegisterCollectionNetHandlers()
        {
            base.method_8("RegisterCollectionNetHandlers", Array.Empty<object>());
        }

        public void RemoveCollectionCard(string cardID, TAG_PREMIUM premium, int count)
        {
            object[] objArray1 = new object[] { cardID, premium, count };
            base.method_8("RemoveCollectionCard", objArray1);
        }

        public void RemoveCollectionNetHandlers()
        {
            base.method_8("RemoveCollectionNetHandlers", Array.Empty<object>());
        }

        public void RemoveDeck(long id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("RemoveDeck", objArray1);
        }

        public void RequestDeckContents(long id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("RequestDeckContents", objArray1);
        }

        public void SendCreateDeck(DeckType deckType, string name, string heroCardID)
        {
            object[] objArray1 = new object[] { deckType, name, heroCardID };
            base.method_8("SendCreateDeck", objArray1);
        }

        public void SendDeleteDeck(long id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SendDeleteDeck", objArray1);
        }

        public void SetDeckBuilder(DeckBuilder deckBuilder)
        {
            object[] objArray1 = new object[] { deckBuilder };
            base.method_8("SetDeckBuilder", objArray1);
        }

        public void SetHasVisitedCollection(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetHasVisitedCollection", objArray1);
        }

        public void SetShowDeckTemplatePageForClass(TAG_CLASS classType, bool show)
        {
            object[] objArray1 = new object[] { classType, show };
            base.method_8("SetShowDeckTemplatePageForClass", objArray1);
        }

        public CollectionDeck SetTaggedDeck(DeckTag tag, long deckId, object callbackData)
        {
            object[] objArray1 = new object[] { tag, deckId, callbackData };
            return base.method_15<CollectionDeck>("SetTaggedDeck", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public void SetTaggedDeck(DeckTag tag, CollectionDeck deck, object callbackData)
        {
            object[] objArray1 = new object[] { tag, deck, callbackData };
            base.method_9("SetTaggedDeck", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public bool ShouldShowDeckTemplatePageForClass(TAG_CLASS classType)
        {
            object[] objArray1 = new object[] { classType };
            return base.method_11<bool>("ShouldShowDeckTemplatePageForClass", objArray1);
        }

        public CollectionDeck StartEditingDeck(DeckTag tag, long deckId, object callbackData)
        {
            object[] objArray1 = new object[] { tag, deckId, callbackData };
            return base.method_14<CollectionDeck>("StartEditingDeck", objArray1);
        }

        public void UpdateCardCounts(NetCache.NetCacheCollection netCacheCards, NetCache.CardDefinition cardDef, int count, int newCount)
        {
            object[] objArray1 = new object[] { netCacheCards, cardDef, count, newCount };
            base.method_8("UpdateCardCounts", objArray1);
        }

        public void UpdateCardsWithNetData()
        {
            base.method_8("UpdateCardsWithNetData", Array.Empty<object>());
        }

        public void UpdateDeckHeroArt(string heroCardID)
        {
            object[] objArray1 = new object[] { heroCardID };
            base.method_8("UpdateDeckHeroArt", objArray1);
        }

        public void UpdateFavoriteHero(TAG_CLASS heroClass, string heroCardId, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { heroClass, heroCardId, premium };
            base.method_8("UpdateFavoriteHero", objArray1);
        }

        public void UpdateShowAdvancedCMOption()
        {
            base.method_8("UpdateShowAdvancedCMOption", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static int DEFAULT_MAX_INSTANCES_PER_DECK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "DEFAULT_MAX_INSTANCES_PER_DECK");
            }
        }

        public bool m_cardStacksRegistered
        {
            get
            {
                return base.method_2<bool>("m_cardStacksRegistered");
            }
        }

        public List<CollectibleCard> m_collectibleCards
        {
            get
            {
                Class267<CollectibleCard> class2 = base.method_3<Class267<CollectibleCard>>("m_collectibleCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_collectionLoaded
        {
            get
            {
                return base.method_2<bool>("m_collectionLoaded");
            }
        }

        public DeckBuilder m_deckBuilder
        {
            get
            {
                return base.method_3<DeckBuilder>("m_deckBuilder");
            }
        }

        public List<TAG_CARD_SET> m_displayableCardSets
        {
            get
            {
                Class266<TAG_CARD_SET> class2 = base.method_3<Class266<TAG_CARD_SET>>("m_displayableCardSets");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_editMode
        {
            get
            {
                return base.method_2<bool>("m_editMode");
            }
        }

        public bool m_hasVisitedCollection
        {
            get
            {
                return base.method_2<bool>("m_hasVisitedCollection");
            }
        }

        public bool m_unloading
        {
            get
            {
                return base.method_2<bool>("m_unloading");
            }
        }

        public bool m_waitingForBoxTransition
        {
            get
            {
                return base.method_2<bool>("m_waitingForBoxTransition");
            }
        }

        public static int MAX_DECKS_PER_PLAYER
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "MAX_DECKS_PER_PLAYER");
            }
        }

        public static int MAX_INSTANCES_PER_CARD_ID
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "MAX_INSTANCES_PER_CARD_ID");
            }
        }

        public static int MAX_INSTANCES_PER_ELITE_CARD_ID
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "MAX_INSTANCES_PER_ELITE_CARD_ID");
            }
        }

        public static int MAX_NUM_TEMPLATE_DECKS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "MAX_NUM_TEMPLATE_DECKS");
            }
        }

        public static int NUM_BASIC_CARDS_PER_CLASS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "NUM_BASIC_CARDS_PER_CLASS");
            }
        }

        public static int NUM_CARDS_GRANTED_POST_TUTORIAL
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "NUM_CARDS_GRANTED_POST_TUTORIAL");
            }
        }

        public static int NUM_CARDS_TO_UNLOCK_ADVANCED_CM
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "NUM_CARDS_TO_UNLOCK_ADVANCED_CM");
            }
        }

        public static int NUM_CLASS_CARDS_GRANTED_PER_CLASS_UNLOCK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "NUM_CLASS_CARDS_GRANTED_PER_CLASS_UNLOCK");
            }
        }

        public static int NUM_CLASSES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "NUM_CLASSES");
            }
        }

        public static int NUM_EXPERT_CARDS_TO_UNLOCK_CRAFTING
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "NUM_EXPERT_CARDS_TO_UNLOCK_CRAFTING");
            }
        }

        public static int NUM_EXPERT_CARDS_TO_UNLOCK_FORGE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CollectionManager", "NUM_EXPERT_CARDS_TO_UNLOCK_FORGE");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CollectibleCardIndex
        {
            public string CardId;
            public TAG_PREMIUM Premium;
        }

        [Attribute38("CollectionManager.DeckSort")]
        public class DeckSort : MonoClass
        {
            public DeckSort(IntPtr address) : this(address, "DeckSort")
            {
            }

            public DeckSort(IntPtr address, string className) : base(address, className)
            {
            }

            public int Compare(CollectionDeck a, CollectionDeck b)
            {
                object[] objArray1 = new object[] { a, b };
                return base.method_11<int>("Compare", objArray1);
            }
        }

        public enum DeckTag
        {
            Editing,
            Arena
        }

        [Attribute38("CollectionManager.PreconDeck")]
        public class PreconDeck : MonoClass
        {
            public PreconDeck(IntPtr address) : this(address, "PreconDeck")
            {
            }

            public PreconDeck(IntPtr address, string className) : base(address, className)
            {
            }

            public long ID
            {
                get
                {
                    return base.method_11<long>("get_ID", Array.Empty<object>());
                }
            }

            public long m_id
            {
                get
                {
                    return base.method_2<long>("m_id");
                }
            }
        }

        [Attribute38("CollectionManager.TemplateDeck")]
        public class TemplateDeck : MonoClass
        {
            public TemplateDeck(IntPtr address) : this(address, "TemplateDeck")
            {
            }

            public TemplateDeck(IntPtr address, string className) : base(address, className)
            {
            }

            public TAG_CLASS m_class
            {
                get
                {
                    return base.method_2<TAG_CLASS>("m_class");
                }
            }

            public string m_description
            {
                get
                {
                    return base.method_4("m_description");
                }
            }

            public string m_displayTexture
            {
                get
                {
                    return base.method_4("m_displayTexture");
                }
            }

            public int m_id
            {
                get
                {
                    return base.method_2<int>("m_id");
                }
            }

            public int m_sortOrder
            {
                get
                {
                    return base.method_2<int>("m_sortOrder");
                }
            }

            public string m_title
            {
                get
                {
                    return base.method_4("m_title");
                }
            }
        }
    }
}

