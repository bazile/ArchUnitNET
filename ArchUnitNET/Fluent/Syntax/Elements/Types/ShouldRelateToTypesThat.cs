﻿using System;
using System.Collections.Generic;
using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.Syntax.ConjunctionFactory;

namespace ArchUnitNET.Fluent.Syntax.Elements.Types
{
    public class ShouldRelateToTypesThat<TRuleTypeShouldConjunction, TReferenceType, TRuleType> :
        ShouldRelateToObjectsThat<TRuleTypeShouldConjunction, TReferenceType, TRuleType>,
        ITypePredicates<TRuleTypeShouldConjunction>
        where TReferenceType : IType
        where TRuleType : ICanBeAnalyzed
    {
        // ReSharper disable once MemberCanBeProtected.Global
        public ShouldRelateToTypesThat(IArchRuleCreator<TRuleType> ruleCreator) : base(ruleCreator)
        {
        }

        public TRuleTypeShouldConjunction Are(Type firstType, params Type[] moreTypes)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.Are(firstType, moreTypes));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction Are(IEnumerable<Type> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.Are(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreAssignableToTypesWithFullNameMatching(string pattern)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.AreAssignableToTypesWithFullNameMatching(pattern));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreAssignableTo(IType firstType, params IType[] moreTypes)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.AreAssignableTo(firstType, moreTypes));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreAssignableTo(Type firstType, params Type[] moreTypes)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.AreAssignableTo(firstType, moreTypes));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreAssignableTo(ObjectProvider<IType> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreAssignableTo(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreAssignableTo(IEnumerable<IType> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreAssignableTo(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreAssignableTo(IEnumerable<Type> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreAssignableTo(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction ImplementInterfaceWithFullNameMatching(string pattern)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.ImplementInterfaceWithFullNameMatching(pattern));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction ResideInNamespaceWithFullNameMatching(string pattern)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.ResideInNamespaceWithFullNameMatching(pattern));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HavePropertyMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.HaveMethodMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HaveFieldMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.HaveFieldMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HaveMethodMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.HaveFieldMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HaveMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.HaveMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNested()
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreNested());
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }


        //Negations


        public TRuleTypeShouldConjunction AreNot(Type firstType, params Type[] moreTypes)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreNot(firstType, moreTypes));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNot(IEnumerable<Type> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreNot(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNotAssignableToTypesWithFullNameMatching(string pattern)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.AreNotAssignableToTypesWithFullNameMatching(pattern));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNotAssignableTo(IType firstType, params IType[] moreTypes)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.AreNotAssignableTo(firstType, moreTypes));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNotAssignableTo(Type firstType, params Type[] moreTypes)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.AreNotAssignableTo(firstType, moreTypes));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNotAssignableTo(ObjectProvider<IType> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreNotAssignableTo(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNotAssignableTo(IEnumerable<IType> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreNotAssignableTo(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNotAssignableTo(IEnumerable<Type> types)
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreNotAssignableTo(types));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction DoNotImplementInterfaceWithFullNameMatching(string pattern)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.DoNotImplementInterfaceWithFullNameMatching(pattern));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction DoNotResideInNamespaceWithFullNameMatching(string pattern)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.DoNotResideInNamespaceWithFullNameMatching(pattern));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction DoNotHavePropertyMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.DoNotHavePropertyMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction DoNotHaveFieldMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.DoNotHaveFieldMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction DoNotHaveMethodMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.DoNotHaveMethodMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction DoNotHaveMemberWithName(string name)
        {
            _ruleCreator.ContinueComplexCondition(
                TypesFilterDefinition<TReferenceType>.DoNotHaveMethodMemberWithName(name));
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction AreNotNested()
        {
            _ruleCreator.ContinueComplexCondition(TypesFilterDefinition<TReferenceType>.AreNotNested());
            return Create<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }
    }
}