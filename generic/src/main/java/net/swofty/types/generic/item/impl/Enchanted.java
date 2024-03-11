package net.swofty.types.generic.item.impl;

import net.swofty.types.generic.item.ItemType;
import net.swofty.types.generic.item.SkyBlockItem;
import net.swofty.types.generic.item.impl.recipes.ShapelessRecipe;
import net.swofty.types.generic.user.statistics.ItemStatistics;

import java.util.Arrays;
import java.util.List;

public interface Enchanted extends CustomSkyBlockItem {
    @Override
    default ItemStatistics getStatistics() {
        return ItemStatistics.EMPTY;
    }

    default SkyBlockRecipe<?> getStandardEnchantedRecipe(SkyBlockRecipe.RecipeType type, ItemType craftingMaterial) {
        List<ItemType> matchTypes = Arrays.stream(ItemType.values())
                .filter(itemType -> itemType.clazz != null)
                .filter(itemType -> itemType.clazz.equals(this.getClass()))
                .toList();

        if (matchTypes.isEmpty()) {
            throw new RuntimeException("No matching ItemType found");
        } else {
            return new ShapelessRecipe(type, new SkyBlockItem(matchTypes.getFirst()))
                    .add(craftingMaterial, 64)
                    .add(craftingMaterial, 64)
                    .add(craftingMaterial, 64)
                    .add(craftingMaterial, 64)
                    .add(craftingMaterial, 32);
        }
    }
}
